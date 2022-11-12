//Draw and Redraw everytime
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpGL;

namespace Lab04
{
    class Draw
    {
        public static List<Object> listObject = new List<Object>();
        public static Object chooseObject(OpenGLControl openGLControl, int _chooseIcon, Point3D center)
        {
            Object _chooseObject = null;

            switch (_chooseIcon)
            {
                case 1://Cube
                    _chooseObject = new Cube();
                    break;
                case 2://Pyramid
                    _chooseObject = new Pyramid();
                    break;
                case 3://Prism
                    _chooseObject = new Prism();
                    break;
                default:
                    break;
            }
            if (_chooseObject != null) // thành công
            {
                _chooseObject.name += Object._countObjects.ToString();
                listObject.Add(_chooseObject);
            }

            return _chooseObject;
        }

        public static void DrawShape(OpenGLControl openGLControl)
        {
            var gl = openGLControl.OpenGL;
            for(int i = 0; i < listObject.Count; i++)
            {
                gl.PushMatrix();
                listObject[i].Draw(openGLControl);
                gl.PopMatrix();
            }
        }
    }
}
