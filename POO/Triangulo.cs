using System;

namespace POO_triangle
{
    public class Triangulo
    {
        private double _a, _b, _c;
      
         public Triangulo(double a_param, double b_param, double c_param)
          {
            _a = a_param;
            _b = b_param;
            _c= c_param;
            
          }

        public bool IsTriangle() {
            if (_a < _b + _c && _b < _a + _c && _c < _a + _b)
                return true;
            else {
                return false;
            }
        }

        public string ToString() {
            string LadosDoTriangulo;
            LadosDoTriangulo = "Lado A [" + this._a + "]\n" + "Lado B [" + this._b + "]\n" + "Lado C [" + this._c + "]\n";
            return LadosDoTriangulo;
        }
    }
}