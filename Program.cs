using Figgle;
using Spectre.Console;

var graphClient = GraphHelper.GetGraphClient();
var healthOverviews = await graphClient.Admin.ServiceAnnouncement.HealthOverviews.GetAsync();

AnsiConsole.Markup("[lime]" +
    FiggleFonts.Standard.Render("M365 HEALTH CHECK") + "[/]\n\n");

var table = Utils.InitTable();

if (healthOverviews != null && healthOverviews.Value != null)
{
  foreach (var value in healthOverviews.Value)
  {
    table.AddRow(value.Service ?? "", Utils.FormatStatus(value.Status.ToString() ?? ""));
  }

  AnsiConsole.Write(table);
}