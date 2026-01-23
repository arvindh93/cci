namespace PracticePrgs;

public class TowerOfHanoi
{
    public void moveDisks(int n, Tower source, Tower dest, Tower buff)
    {
        if (n == 0)
        {
            return;
        }
        //move n-1 disks to buff as destinaion
        moveDisks(n-1, source, buff, dest);
        //move final disk to actual destination
        dest.Disks.Push(source.Disks.Pop());
        //move back n-1 disk from buff to destination
        moveDisks(n-1, buff, dest, source);
    }
}

public class Tower(int i, Stack<int> disks)
{
    public int Index => i;
    public Stack<int> Disks = disks;

    public int[] GetDisksArray()
    {
        return Disks.ToArray();
    }
}