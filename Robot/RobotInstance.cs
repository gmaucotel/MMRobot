using System;

public class RobotInstance 
{
    private Direction dir { get; set; }
    private int _x; 
    private int x
    {
        get
        {
            return this._x;
        }
        set
        {
            if(value>4 || value < 0)
            {
                throw new ArgumentOutOfRangeException("X Value Out of Range");
            }
            else
            {
                this._x = value;
            }
        }
    }
    private int _y; 
    private int y
    {
        get
        {
            return this._y;
        }
        set
        {
            if (value > 4 || value < 0)
            {
                throw new ArgumentOutOfRangeException("Y Value Out of Range");
            }
            else
            {
                this._y = value;
            }
        }
    }
    public RobotInstance(String dir, int x, int y)
	{
        this.dir = new Direction(dir);
        this.x = x;
        this.y = y; 
	}

    public void Rotate(String rotation)
    {
        this.dir.Rotate(rotation);
    }

    public void Move()
    {
        this.x += this.dir.x;
        this.y += this.dir.y;
    }

    public override String ToString()
    {
        return this.x.ToString() + "," + this.y.ToString() + "," + this.dir.ToString();
    }
}
