using System;

public class Matrix
{
    private int[,] data;
    private int rows;
    private int columns;

    public Matrix(int rows, int columns)
    {
        this.rows = rows;
        this.columns = columns;
        data = new int[rows, columns];
    }

    public int this[int i, int j]
    {
        get { return data[i, j]; }
        set { data[i, j] = value; }
    }

    public void InputMatrix()
    {
        Console.WriteLine($"Введіть елементи матриці {rows}x{columns}:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"Елемент [{i},{j}]: ");
                data[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    public void DisplayMatrix()
    {
        Console.WriteLine("Матриця:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{data[i, j]} ");
            }
            Console.WriteLine();
        }
    }

    public int FindMax()
    {
        int max = data[0, 0];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                if (data[i, j] > max)
                    max = data[i, j];
            }
        }
        return max;
    }

    public int FindMin()
    {
        int min = data[0, 0];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                if (data[i, j] < min)
                    min = data[i, j];
            }
        }
        return min;
    }

    public static Matrix operator +(Matrix matrix1, Matrix matrix2)
    {
        if (matrix1.rows != matrix2.rows || matrix1.columns != matrix2.columns)
            throw new ArgumentException("Розміри матриць повинні бути однаковими.");

        Matrix result = new Matrix(matrix1.rows, matrix1.columns);
        for (int i = 0; i < matrix1.rows; i++)
        {
            for (int j = 0; j < matrix1.columns; j++)
            {
                result[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }
        return result;
    }

    public static Matrix operator -(Matrix matrix1, Matrix matrix2)
    {
        if (matrix1.rows != matrix2.rows || matrix1.columns != matrix2.columns)
            throw new ArgumentException("Розміри матриць повинні бути однаковими.");

        Matrix result = new Matrix(matrix1.rows, matrix1.columns);
        for (int i = 0; i < matrix1.rows; i++)
        {
            for (int j = 0; j < matrix1.columns; j++)
            {
                result[i, j] = matrix1[i, j] - matrix2[i, j];
            }
        }
        return result;
    }

    public static Matrix operator *(Matrix matrix1, Matrix matrix2)
    {
        if (matrix1.columns != matrix2.rows)
            throw new ArgumentException("Кількість стовпців першої матриці повинна дорівнювати кількості рядків другої матриці.");

        Matrix result = new Matrix(matrix1.rows, matrix2.columns);
        for (int i = 0; i < matrix1.rows; i++)
        {
            for (int j = 0; j < matrix2.columns; j++)
            {
                for (int k = 0; k < matrix1.columns; k++)
                {
                    result[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }
        return result;
    }

    public static Matrix operator *(Matrix matrix, int scalar)
    {
        Matrix result = new Matrix(matrix.rows, matrix.columns);
        for (int i = 0; i < matrix.rows; i++)
        {
            for (int j = 0; j < matrix.columns; j++)
            {
                result[i, j] = matrix[i, j] * scalar;
            }
        }
        return result;
    }

    public static bool operator ==(Matrix matrix1, Matrix matrix2)
    {
        if (matrix1.rows != matrix2.rows || matrix1.columns != matrix2.columns)
            return false;

        for (int i = 0; i < matrix1.rows; i++)
        {
            for (int j = 0; j < matrix1.columns; j++)
            {
                if (matrix1[i, j] != matrix2[i, j])
                    return false;
            }
        }
        return true;
    }

    public static bool operator !=(Matrix matrix1, Matrix matrix2)
    {
        return !(matrix1 == matrix2);
    }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        Matrix other = (Matrix)obj;
        return this == other;
    }

    public override int GetHashCode()
    {
        return data.GetHashCode();
    }
}
