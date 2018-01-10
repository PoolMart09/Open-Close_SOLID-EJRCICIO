using System;
using System.Collections.Generic;

public interface IFormaGeometrica{
    double Area();
    double Perimetro();
}

// Procedimiento del Rectangulo
public class Rectangulo : IFormaGeometrica
{
    public double Sides { get; } = 4;
    public double Height { get; set; }
    public double Width { get; set; }

    public double Area(){
        return Height * Width;
    }

    public double Perimetro(){
        return Height * 2 + Width * 2;
    }
}
//Procedimiento del triangulo
public class EquilateroTriangulo : IFormaGeometrica
{
    public double Sides { get; } = 3;
    public double SidesLenth {get; set;}

    public double Area(){
        return Math.Sqrt(3)* Math.Pow(SidesLenth, 2)/4;
    }

    public double Perimetro(){
        return SidesLenth * 3;
    }
}
//Operacion encargada de calcular el area de la figura ingresada
public class OperacionArea 
{
    public double Sum(IEnumerable<IFormaGeometrica> formas)
    {
        double area= 0;
        foreach (var forma in formas)
           area += forma.Area();
        return area;
        
    }
}

//Operacion encargada de calcular el perimetro de las figura
public class OperacionPerimetro
{
    public double Sum(IEnumerable<IFormaGeometrica> formas)
    {
        double perimetro= 0;
        foreach (var forma in formas)
           perimetro += forma.Perimetro();
        return perimetro;
    
    }
}

public class Total
        {
    public double TotalAreas { get; private set; }
    public double TotalPerimetros { get; private set;}
     public void Calcular()
        {
            var figuras= new IFormaGeometrica[]
            {
                new Rectangulo {Width = 10, Height= 5},
                new Rectangulo {Width = 15, Height= 10},
                new EquilateroTriangulo {SidesLenth= 4},
                new EquilateroTriangulo {SidesLenth= 8},
                                
            };
            
            var SumaDeAreas = new OperacionArea();
            var SumaDePerimetros = new OperacionPerimetro();  


            TotalAreas = SumaDeAreas.Sum(figuras);
            TotalPerimetros = SumaDePerimetros.Sum(figuras);

            
            }
        }
    

