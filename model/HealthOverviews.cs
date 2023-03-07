public class HealthOverviews
{
  public List<Value> value { get; set; }
}

public class Value
{
  public string service { get; set; }
  public string status { get; set; }
  public string id { get; set; }
}