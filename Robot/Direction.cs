using System;

public class Direction
{
    public int x { get; private set; }
    public int y { get; private set; }
	public Direction(String direc)
	{
        this.x = 0;
        this.y = 0;
        switch (direc)
        {
            case "NORTH":
                this.y = 1;
                break;
            case "SOUTH":
                this.y = -1;
                break;
            case "WEST":
                this.x = -1;
                break;
            case "EAST":
                this.x = 1;
                break;
            default:
                throw new ArgumentException("Invalid direction");
        }
	}

    /**
     * rotation of the direction by pi/2 or -pi/2
     * cos(angle) is always 0, no need to use matrices here
     *
     * */
    public void Rotate(String rotation) {
        int inter = this.x;
        switch (rotation) {
            case "LEFT":
                this.x = -this.y;
                this.y = inter;
                break;
            case "RIGHT":
                this.x = this.y;
                this.y = -inter;
                break;
            default:
                throw new ArgumentException("Invalid rotation");
        }
    }

    public override String ToString()
    {
        if (this.x == 0 && this.y == 1)
        {
            return "NORTH";
        }else if(this.x == 0 && this.y == -1)
        {
            return "SOUTH";
        }
        else if (this.x == -1 && this.y == 0)
        {
            return "WEST";
        }
        else if (this.x == 1 && this.y == 0)
        {
            return "EAST";
        }
        else
        {
            throw new Exception("Invalid direction attributes");
        }
    }
}
