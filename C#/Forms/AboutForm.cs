﻿#region Copyright
//=======================================================================================
// Microsoft Business Platform Division Customer Advisory Team  
//
// This sample is supplemental to the technical guidance published on the community
// blog at http://www.appfabriccat.com/. 
// 
// Author: Paolo Salvatori
//=======================================================================================
// Copyright © 2011 Microsoft Corporation. All rights reserved.
// 
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, EITHER 
// EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED WARRANTIES OF 
// MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE. YOU BEAR THE RISK OF USING IT.
//=======================================================================================
#endregion

#region Using Directives
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Microsoft.AppFabric.CAT.WindowsAzure.Samples.ServiceBusExplorer.Properties;
#endregion

namespace Microsoft.AppFabric.CAT.WindowsAzure.Samples.ServiceBusExplorer
{
    public partial class AboutForm : Form
    {
        #region Private Fields
        private readonly Bitmap bitmap = new Bitmap(Resources.Azure);
        /// <summary>
        /// A collection of Shape based objects
        /// </summary>
        readonly ShapeCollection shapes = new ShapeCollection();

        /// <summary>
        /// The message-driven timer 
        /// </summary>
        readonly Timer timer = new Timer(); 
        #endregion

        #region Public Constructor
        public AboutForm()
        {
            InitializeComponent();

            //This form is double buffered
            SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.DoubleBuffer |
                ControlStyles.ResizeRedraw |
                ControlStyles.UserPaint,
                true);

            //A random number generator for the initial setup
            var random = new Random();
            const int count = 50;

            //We create 100 objects
            for (var i = 0; i < count; i++)
            {
                var shape = new Picture(bitmap)
                                {
                                    Limits = ClientRectangle,
                                    Location = new Point(random.Next(ClientRectangle.Width + 16),
                                                         random.Next(ClientRectangle.Height + 16)),
                                    Size = new Size(1 + random.Next(100), 1 + random.Next(100)),
                                    BackColor = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255)),
                                    ForeColor = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255)),
                                    RotationDelta = random.Next(20),
                                    Transparency = (float) random.NextDouble(),
                                    LineThickness = random.Next(10),
                                    Vector = new Size(-10 + random.Next(20), -10 + random.Next(20))
                                };

                //and added to the list of shapes
                shapes.Add(shape);
            }

            //set up the timer so that animation can take place
            timer.Interval = 40;
            timer.Tick += timer_Tick;
            timer.Enabled = true;
        }
        #endregion

        #region Event Handlers
        private void btnOk_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mainGroupBox_Paint(object sender, PaintEventArgs e)
        {
            var borderRectangle = new Rectangle(12, 20, 456, 288);
            ControlPaint.DrawBorder3D(e.Graphics, borderRectangle, Border3DStyle.Raised, Border3DSide.All);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            foreach (Shape shape in shapes)
            {
                shape.Tick();
            }
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            foreach (Shape shape in shapes)
            {
                shape.Draw(e.Graphics);
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            timer.Enabled = false;
            timer.Dispose();
            base.OnClosing(e);
        }

        /// <summary>
        /// Updates the limits of all current shapes so that they don't disappear off-screen
        /// </summary>
        /// <param name="e"></param>
        protected override void OnSizeChanged(EventArgs e)
        {
            foreach (Shape shape in shapes)
            {
                shape.Limits = ClientRectangle;
            }
            base.OnSizeChanged(e);
        }
        #endregion
    }

    public class Shape
    {
        #region Private Fields
        private GraphicsState state;
        private float transparency;
        #endregion

        #region Public Properties
        public Point Location { get; set; }

        public Size Size { get; set; }

        public Color BackColor { get; set; }

        public Color ForeColor { get; set; }

        public int LineThickness { get; set; }

        public float Rotation { get; set; }

        public Size Vector { get; set; }

        public float RotationDelta { get; set; }

        public Rectangle Limits { get; set; }

        public float Transparency
        {
            get { return transparency; }
            set
            {
                transparency = (value >= 0 ? (value <= 1 ? value : 1) : 0);
            }
        }
        #endregion

        /// <summary>
        /// Sets up the transform for each shape
        /// </summary>
        /// <remarks>
        /// As each shape is drawn the transform for that shape including rotation and location is made to a new Matrix object.
        /// This matrix is used to modify the graphics transform <i>For each shape</i> 
        /// </remarks>
        /// <param name="g">The Graphics being drawn on</param>
        protected void SetupTransform(Graphics g)
        {
            state = g.Save();
            var matrix = new Matrix();
            matrix.Rotate(Rotation, MatrixOrder.Append);
            matrix.Translate(Location.X, Location.Y, MatrixOrder.Append);
            g.Transform = matrix;
        }

        /// <summary>
        /// Simply restores the original state of the Graphics object
        /// </summary>
        /// <param name="g">The Graphics object being drawn upon</param>
        protected void RestoreTransform(Graphics g)
        {
            g.Restore(state);
        }

        public void Draw(Graphics g)
        {
            SetupTransform(g);
            RenderObject(g);
            RestoreTransform(g);
        }

        public virtual void Tick()
        {
            //ensure that the object is in the page.
            //this is in case the window was resized
            if (Location.X > Limits.Right)
            {
                Location = new Point(Limits.Right - 1, Location.Y);
            }
            if (Location.Y > Limits.Bottom)
            {
                Location = new Point(Location.X, Limits.Bottom - 1);
            }
            //Generate a new location adding in the vectors
            //check the limits and switch vector directions as needed
            var newX = Location.X + Vector.Width;
            if (newX > Limits.Right || newX < Limits.Left)
            {
                Vector = new Size(-1 * Vector.Width, Vector.Height);
            }
            var newY = Location.Y + Vector.Height;
            if (newY > Limits.Bottom || newY < Limits.Top)
            {
                Vector = new Size(Vector.Width, -1 * Vector.Height);
            }
            //This is the new position
            Location = new Point(Location.X + Vector.Width, Location.Y + Vector.Height);

            //Apply the rotation factor
            Rotation += RotationDelta;

            //Limit just to be neat
            Rotation = (Rotation < 360f ? (Rotation >= 0 ? Rotation : Rotation + 360f) : Rotation - 360f);
        }

        public virtual void RenderObject(Graphics g)
        {
        }

    }

    public class Square : Shape
    {
        /// <summary>
        /// Draws a square. Note that the square is drawn about the origin.
        /// </summary>
        /// <param name="g">The graphics to draw on.</param>
        public override void RenderObject(Graphics g)
        {
            var pen = new Pen(ForeColor, LineThickness);
            var solidBrush = new SolidBrush(Color.FromArgb((int)(255 * Transparency), BackColor));
            g.FillRectangle(solidBrush, -Size.Width / 2, -Size.Height / 2, Size.Width, Size.Height);
            g.DrawRectangle(pen, -Size.Width / 2, -Size.Height / 2, Size.Width, Size.Height);
            solidBrush.Dispose();
            pen.Dispose();
        }

    }

    public class Picture : Shape
    {
        #region Private Fields
        private readonly Bitmap bitmap;
        #endregion

        public Picture(Bitmap bitmap)
        {
            this.bitmap = bitmap;
        }

        /// <summary>
        /// Draws a bitmap. 
        /// </summary>
        /// <param name="g">The graphics to draw on.</param>
        public override void RenderObject(Graphics g)
        {
            g.DrawImage(bitmap, -Size.Width / 2, -Size.Height / 2);
        }
    }

    public class Star : Shape
    {
        /// <summary>
        /// Draws a star. Note that the star is drawn about the origin.
        /// </summary>
        /// <param name="g">The graphics to draw on.</param>
        public override void RenderObject(Graphics g)
        {
            var pen = new Pen(ForeColor, LineThickness);
            var solidBrush = new SolidBrush(Color.FromArgb((int)(255 * Transparency), BackColor));
            var points = new Point[11];
            var pointy = true;
            float a = 0;
            for (var i = 0; i < 10; i++)
            {
                var distance = pointy ? 1 : 0.6f;
                points[i] = new Point((int)(distance * (Size.Width / 2) * Math.Cos(a)), (int)(distance * (Size.Height / 2) * Math.Sin(a)));
                a += (float)Math.PI * 2 / 10;
                pointy = !pointy;
            }
            points[10] = points[0];
            g.FillPolygon(solidBrush, points);
            g.DrawPolygon(pen, points);
            solidBrush.Dispose();
            pen.Dispose();
        }
    }

    public class Pentagon : Shape
    {
        /// <summary>
        /// Draws a pentagon. Note that the pentagon is drawn about the origin.
        /// </summary>
        /// <param name="g">The graphics to draw on.</param>
        public override void RenderObject(Graphics g)
        {
            var pen = new Pen(ForeColor, LineThickness);
            var solidBrush = new SolidBrush(Color.FromArgb((int)(255 * Transparency), BackColor));
            var points = new Point[6];
            float a = 0;
            for (var i = 0; i < 5; i++)
            {
                points[i] = new Point((int)((Size.Width / 2) * Math.Cos(a)), (int)((Size.Height / 2) * Math.Sin(a)));
                a += (float)Math.PI * 2 / 5;
            }
            points[5] = points[0];
            g.FillPolygon(solidBrush, points);
            g.DrawPolygon(pen, points);
            solidBrush.Dispose();
            pen.Dispose();
        }

    }

    /// <summary>
    /// Manages a collection of shape objects
    /// </summary>
    public class ShapeCollection : CollectionBase
    {
        public void Add(Shape shape)
        {
            List.Add(shape);
        }

        public void Remove(Shape shape)
        {
            List.Remove(shape);
        }

        public Shape this[int index]
        {
            get
            {
                return (Shape)List[index];
            }
            set
            {
                List[index] = value;
            }
        }
    }
}
