using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AE02_VectorGUI
{
    public class Vector
    {
        // Attributes
        private double[] _vector;

        // Constructor
        public Vector(double[] values)
        {
            this._vector = values;
        }

        // Get & Set
        public double[] GetVector()
        {
            return _vector;
        }

        public void SetVector(double[] values)
        {
            this._vector = values;
        }

        // Methods
        public Vector Add(Vector vec)
        {
            CheckLengths(vec);

            double[] result = new double[_vector.Length];
            for (int i = 0; i < _vector.Length; i++)
            {
                result[i] = _vector[i] + vec.GetVector()[i];
            }

            return new Vector(result);
        }

        public Vector Sub(Vector vec)
        {
            CheckLengths(vec);

            double[] result = new double[_vector.Length];
            for (int i = 0; i < _vector.Length; i++)
            {
                result[i] = _vector[i] - vec.GetVector()[i];
            }

            return new Vector(result);
        }

        public double Mul(Vector vec)
        {
            CheckLengths(vec);

            double result = 0;
            for (int i = 0; i < _vector.Length; i++)
            {
                result += _vector[i] * vec.GetVector()[i];
            }

            return result;
        }

        public Vector Div(Vector vec)
        {
            double[] result = new double[_vector.Length];
            for (int i = 0; i < _vector.Length; i++)
            {
                result[i] = _vector[i] / vec.GetVector()[0];
            }

            return new Vector(result);
        }

        private void CheckLengths(Vector vec)
        {
            if (_vector.Length != vec.GetVector().Length)
                throw new ArgumentException("Vectors must have the same length.");
        }

        // Override
        public override string ToString()
        {
            // Convert the double[] array into a single string, 
            // where each element is separated by a comma and a space (", ").
            return string.Join(", ", _vector);
        }
    }
}
