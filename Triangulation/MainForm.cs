using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Accord.Imaging.Converters;
using Accord.MachineLearning;
using Accord.Math;
using Accord.Math.Distances;
using Accord.Statistics.Distributions.Fitting;
using Accord.Statistics.Distributions.Univariate;
using AForge.Imaging;
using TriangleNet;
using TriangleNet.Geometry;
using TriangleNet.Topology;
using Image = System.Drawing.Image;

namespace Triangulation
{
    public partial class MainForm : Form
    {
        private Mesh triangulated = null;
        private byte[,,] imageBits = null;
        private byte[,,] finalBits = null;
        private Bitmap realImage = null;
        private Bitmap finalImage = null;
        public MainForm()
        {
            InitializeComponent();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenImg.FileName = "";
            if (OpenImg.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                MainImage.Image = Image.FromFile(OpenImg.FileName);
                realImage = (Bitmap) MainImage.Image.Clone();
                finalImage = (Bitmap)MainImage.Image.Clone();
                imageBits = BitmapToByteRgbQ((Bitmap)MainImage.Image);

                MainChart.Series.Clear();
                FinalImage.Image = null;
            }
            catch
            {
                Application.DoEvents();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveImg.FileName = "";
            if (SaveImg.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                FinalImage.Image.Save(SaveImg.FileName, ImageFormat.Png);

            }
            catch
            {
                Application.DoEvents();
            }
        }

        private void triangulateToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MainImage.Image == null)
                return;

           TD();
        }


        void TD()
        {
            if(!Triang.Checked)
                return;

            if((int)PartCount.Value == 1)
                return;

            Polygon p = new Polygon();

            List<Vertex> corners;
            if (UserDeepSearch.Checked)
            {
                MoravecCornersDetector scd = new MoravecCornersDetector();
                corners = scd.ProcessImage(finalImage).Select(x => new Vertex(x.X, x.Y)).ToList();
            }
            else
            {
                SusanCornersDetector scd = new SusanCornersDetector();
                corners = scd.ProcessImage(finalImage).Select(x => new Vertex(x.X, x.Y)).ToList();
            }

            corners.ForEach(delegate (Vertex v)
            {
                p.Add(v);
            });

            triangulated = (Mesh)p.Triangulate();


            using (Graphics graphics = Graphics.FromImage(finalImage))
            {
                foreach (Triangle t in triangulated.Triangles)
                {
                    PointF[] points =
                    {
                        new PointF((float) t.GetVertex(0).X, (float) t.GetVertex(0).Y),
                        new PointF((float) t.GetVertex(1).X, (float) t.GetVertex(1).Y),
                        new PointF((float) t.GetVertex(2).X, (float) t.GetVertex(2).Y),
                    };

                    int ColR = imageBits[0, (int)points[0].Y, (int)points[0].X] +
                               imageBits[0, (int)points[1].Y, (int)points[1].X] +
                               imageBits[0, (int)points[2].Y, (int)points[2].X];

                    int ColG = imageBits[1, (int)points[0].Y, (int)points[0].X] +
                               imageBits[1, (int)points[1].Y, (int)points[1].X] +
                               imageBits[1, (int)points[2].Y, (int)points[2].X];

                    int ColB = imageBits[2, (int)points[0].Y, (int)points[0].X] +
                               imageBits[2, (int)points[1].Y, (int)points[1].X] +
                               imageBits[2, (int)points[2].Y, (int)points[2].X];


                    Brush brush = new SolidBrush(Color.FromArgb(ColR / 3, ColG / 3, ColB / 3));
                    graphics.FillPolygon(brush, points);
                }
            }
        }
        public unsafe byte[,,] BitmapToByteRgbQ(Bitmap bmp)
        {
            int width = bmp.Width,
                height = bmp.Height;
            byte[,,] res = new byte[3, height, width];
            BitmapData bd = bmp.LockBits(new System.Drawing.Rectangle(0, 0, width, height), ImageLockMode.ReadOnly,
                PixelFormat.Format24bppRgb);
            try
            {
                byte* curpos;
                fixed (byte* _res = res)
                {
                    byte* _r = _res, _g = _res + width * height, _b = _res + 2 * width * height;
                    for (int h = 0; h < height; h++)
                    {
                        curpos = ((byte*)bd.Scan0) + h * bd.Stride;
                        for (int w = 0; w < width; w++)
                        {
                            *_b = *(curpos++);
                            ++_b;
                            *_g = *(curpos++);
                            ++_g;
                            *_r = *(curpos++);
                            ++_r;
                        }
                    }
                }
            }
            finally
            {
                bmp.UnlockBits(bd);
            }
            return res;
        }


        public void Bresenham4Line(Graphics g, Color clr, int x0, int y0, int x1, int y1)
        {
            int dx = (x1 > x0) ? (x1 - x0) : (x0 - x1);
            int dy = (y1 > y0) ? (y1 - y0) : (y0 - y1);
            int sx = (x1 >= x0) ? (1) : (-1);
            int sy = (y1 >= y0) ? (1) : (-1);

            if (dy < dx)
            {
                int d = (dy << 1) - dx;
                int d1 = dy << 1;
                int d2 = (dy - dx) << 1;
                PutPixel(g, clr, x0, y0, 255);
                int x = x0 + sx;
                int y = y0;
                for (int i = 1; i <= dx; i++)
                {
                    if (d > 0)
                    {
                        d += d2;
                        y += sy;
                    }
                    else
                        d += d1;
                    PutPixel(g, clr, x, y, 255);
                    x += sx;
                }
            }
            else
            {
                int d = (dx << 1) - dy;
                int d1 = dx << 1;
                int d2 = (dx - dy) << 1;
                PutPixel(g, clr, x0, y0, 255);
                int x = x0;
                int y = y0 + sy;
                for (int i = 1; i <= dy; i++)
                {
                    if (d > 0)
                    {
                        d += d2;
                        x += sx;
                    }
                    else
                        d += d1;
                    PutPixel(g, clr, x, y, 255);
                    y += sy;
                }
            }
        }

        private static void PutPixel(Graphics g, Color col, int x, int y, int alpha)
        {
            g.FillRectangle(new SolidBrush(Color.FromArgb(alpha, col)), x, y, 1, 1);
        }

        private void drawPolygonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (triangulated == null)
                return;

            dp();
        }

        void dp()
        {
            if(!DrawPoly.Checked)
                return;

            if ((int)PartCount.Value == 1)
                return;
            
            using (Graphics graphics = Graphics.FromImage(finalImage))
            {
                foreach (Triangle t in triangulated.Triangles)
                {
                    PointF[] points =
                    {
                        new PointF((float) t.GetVertex(0).X, (float) t.GetVertex(0).Y),
                        new PointF((float) t.GetVertex(1).X, (float) t.GetVertex(1).Y),
                        new PointF((float) t.GetVertex(2).X, (float) t.GetVertex(2).Y),
                    };

                    Bresenham4Line(graphics, Color.Red, (int)points[0].X, (int)points[0].Y, (int)points[1].X, (int)points[1].Y);
                    Bresenham4Line(graphics, Color.Red, (int)points[1].X, (int)points[1].Y, (int)points[2].X, (int)points[2].Y);
                    Bresenham4Line(graphics, Color.Red, (int)points[2].X, (int)points[2].Y, (int)points[0].X, (int)points[0].Y);
                }
            }
        }

        void cluster(ref Bitmap bitmap)
        {
            if (!PreCluster.Checked)
                return;

            int _k = (int)PartCount.Value;

            Bitmap image = realImage;

            ImageToArray imageToArray = new ImageToArray(min: -1, max: +1);
            ArrayToImage arrayToImage = new ArrayToImage(image.Width, image.Height, min: -1, max: +1);

            double[][] pixels; imageToArray.Convert(image, out pixels);

            KMeans kmeans = new KMeans(_k, new SquareEuclidean())
            {
                Tolerance = 0.05
            };

            int[] idx = kmeans.Learn(pixels).Decide(pixels);

            pixels.Apply((x, i) => kmeans.Clusters.Centroids[idx[i]], result: pixels);

            Bitmap result; arrayToImage.Convert(pixels, out result);
            bitmap =  result;
        }
        void gg()
        {
            if(!GraphASE.Checked)
                return;

            finalBits = BitmapToByteRgbQ(finalImage);
            List<double> ase = new List<double>();
            for (int i = 0; i < imageBits.GetLength(1); i++)
            for (int j = 0; j < imageBits.GetLength(2); j++)
            {
                double ss = (float)Math.Pow(
                    (double)(finalBits[0, i, j] - imageBits[0, i, j] +
                     finalBits[1, i, j] - imageBits[1, i, j] +
                     finalBits[2, i, j] - imageBits[2, i, j]) / 9
                    , 2);

                ase.Add(Math.Sqrt(ss));

                }
            MainChart.Series.Clear();
            Series s = new Series()
            {
                ChartType = SeriesChartType.Column
            };
            for (int i = 0; i < ase.Count; i++)
            {
                s.Points.AddXY(i, ase[i]);
            }

            MainChart.Series.Add(s);
        }

        private void Start_Click(object sender, EventArgs e)
        {

            cluster(ref finalImage);
            TD();
            dp();
            gg();
            FinalImage.Image = finalImage;
        }
    }
}
