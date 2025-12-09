using raft.components;
using raft.Managers;
using Spectre.Console;
using Spectre.Console.Rendering;

namespace raft;
// Welcome to RAFT RAFT RAFT (Redeem allowance and fuel tracker)
class Program {

    public static async Task Main(string[] args) {
        
        //TODO: Add check if the terminal is in a certain size. Inform 
        //user if not and force user to change size
        Console.SetWindowSize(500, 500);
        
        UiManager.Init();
        
        
        CompUserInput.InputType inputType = CompUserInput.InputType.None;
        CompUserInput userInput = new CompUserInput();
        
        
        await AnsiConsole.Live(UiManager.MainLayout.Layout)
            .StartAsync(async ctx => {
                while (inputType != CompUserInput.InputType.Exit) {
                    inputType = userInput.GetUserInput();
                    UiManager.MainLayout.UpdateContent(CompLayout.Section.statistics, new Panel(
                        Align.Center(
                            new Markup($"Your input [blue]{inputType}[/]"),
                            VerticalAlignment.Middle)));
                    UiManager.MainLayout.UpdateContent(CompLayout.Section.calendar, UiManager.CalendarYearGird.CalendarGird);
                    ctx.Refresh();
                    await Task.Delay(TimeSpan.FromSeconds(1));
                }
            });
        
    }
}

