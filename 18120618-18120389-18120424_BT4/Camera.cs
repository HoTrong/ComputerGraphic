using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using SharpGL;

namespace Lab04
{
    public class Camera
    {
        public double _eyeX, _eyeY, _eyeZ;
        public double _viewX, _viewY, _viewZ;
        public double radius;
        public double theta;
        public double phi;

        public Camera()
        {
            _eyeX = 20;
            _eyeY = 10;
            _eyeZ = 20;
            _viewX = 0;
            _viewY = 0;
            _viewZ = 0;

            Radius();
            Theta();
            Phi();
        }

        // Tính góc theta hiện tại
        public void Theta()
        {
            theta = Math.Atan((_eyeX - _viewX) / (_eyeZ - _viewZ));
        }

        // Tính góc phi hiện tại
        public void Phi()
        {
            phi = Math.Asin((_eyeY - _viewY) / radius);
        }

        // Tính bán kính của hình cầu khi thay đổi vị trí camera (khoảng cách từ eye đến view)
        public void Radius()
        {
            radius = Math.Sqrt(Math.Pow(_eyeX - _viewX, 2) + Math.Pow(_eyeY - _viewY, 2) + Math.Pow(_eyeZ - _viewZ, 2));
        }

        // Phóng to - di chuyển vị trí camera lại gần điểm nhìn
        public void ZoomIn()
        {
            _eyeX += -0.02f * _eyeX;
            _eyeY += -0.02f * _eyeY;
            _eyeZ += -0.02f * _eyeZ;

            // Cập nhật lại các góc nhìn
            Radius();
            Theta();
            Phi();
        }

        // Thu nhỏ - di chuyển vị trí camera ra xa điểm nhìn
        public void ZoomOut()
        {
            _eyeX += 0.02f * _eyeX;
            _eyeY += 0.02f * _eyeY;
            _eyeZ += 0.02f * _eyeZ;

            // Cập nhật lại các góc nhìn
            Radius();
            Theta();
            Phi();
        }

        public void RotateRight()
        {
            theta += 0.02;
            _eyeX = _viewX + radius * Math.Cos(phi) * Math.Sin(theta);
            _eyeZ = _viewZ + radius * Math.Cos(phi) * Math.Cos(theta);
        }

        public void RotateLeft()
        {
            theta -= 0.02;
            _eyeX = _viewX + radius * Math.Cos(phi) * Math.Sin(theta);
            _eyeZ = _viewZ + radius * Math.Cos(phi) * Math.Cos(theta);
        }

        public void RotateUp()
        {
            phi += 0.02;
            _eyeY = _viewY + radius * Math.Sin(phi);
            _eyeZ = _viewZ + radius * Math.Cos(phi) * Math.Cos(theta);
            _eyeX = _viewX + radius * Math.Cos(phi) * Math.Sin(theta);
        }

        public void RotateDown()
        {
            phi -= 0.02;
            _eyeY = _viewY + radius * Math.Sin(phi);
            _eyeZ = _viewZ + radius * Math.Cos(phi) * Math.Cos(theta);
            _eyeX = _viewX + radius * Math.Cos(phi) * Math.Sin(theta);
        }
    }
}
