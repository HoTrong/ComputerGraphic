using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using SharpGL;
using SharpGL.SceneGraph.Assets;

namespace Lab04
{
    abstract class Object
    {
        public List<Point3D> listPoint3D; // danh sách tất cả đỉnh của đối tượng
        public Color _color; // màu nền
        public double _length; // chiều dài cạnh
        public double _height; // chiếu cao hình
        public bool _IsSelected;
        public string name = "Object ";
        public int type;
        public static int _countObjects = 0;

        public double angleX, angleY, angleZ;
        public double tX, tY, tZ;
        public double sX, sY, sZ;

        public bool isTexture;
        public Texture texture;

        public Object() { }
        public virtual void Draw(OpenGLControl gl)
        {
            gl.OpenGL.Color(_color.R / 255.0, _color.G / 255.0, _color.B / 255.0);
        }
        public void Update() { }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int GetCount() { return _countObjects; }
        ~Object() { }
    }
}
