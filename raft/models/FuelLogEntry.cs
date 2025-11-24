namespace raft.models;

public class FuelLogEntry {
    public DateOnly Date { get; set; }
    public DateTime Time { get; set; }
    public float Amount { get; set; }
    public float Volume { get; set; }
}