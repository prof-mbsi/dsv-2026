public class ClA
{
    public int AtA { get; set; }

    public string AtB { get; set; }

    public List<ClB> AtC { get; set; } = new();

    public double MeA()
    {
        if (AtC.Count == 0)
            return 0;

        return AtC.Average(x => x.AtD);
    }
}