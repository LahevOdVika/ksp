namespace Naledi;

public class Vector
{
    public int x;
    public int y;

    public Vector(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public void prictiVektor(Vector v)
    {
        x += v.x;
        y += v.y;
    }

    public bool jeVPoli(int velikostX, int velikostY)
    {
        return (x >= 0 && x <= velikostX && y >= 0 && y <= velikostY);
    }
}