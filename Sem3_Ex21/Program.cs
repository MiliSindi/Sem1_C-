// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
void printGipo (double ax, double ay,double az,double bx, double by,double bz )
{
    double deltax = ax - bx;
    double deltay = ay - by;
    double deltaz = ax - bz;
    double c = Math.Sqrt(deltax*deltax+deltay*deltay+deltaz*deltaz);
    System.Console.WriteLine(c);
}
printGipo (2,8,7,-8,-3,0);
