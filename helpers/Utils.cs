using Spectre.Console;

public static class Utils
{
  public static string FormatStatus(string status)
  {
    switch (status)
    {
      case "ServiceOperational":
      case "ServiceRestored":
        return $"[lime]{status}[/]";
      case "ServiceDegradation":
      case "ServiceInterruption":
      case "ExtendedRecovery":
        return $"[red]{status}[/]";
      case "UnknownFutureValue":
      case "Investigating":
      case "RestoringService":
      case "VerifyingService":
      case "PostIncidentReviewPublished":
      case "FalsePositive":
      case "InvestigationSuspended":
      case "Resolved":
      case "MitigatedExternal":
      case "Mitigated":
      case "ResolvedExternal":
      case "Confirmed":
      case "Reported":
        return $"[yellow]{status}[/]";
      default:
        return $"{status}";
    }
  }

  public static Table InitTable()
  {
    var table = new Table();
    table.Border = TableBorder.Rounded;

    table.AddColumn("SERVICE");
    table.AddColumn("STATUS");
    return table;
  }
}