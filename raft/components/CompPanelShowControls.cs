using Spectre.Console;

namespace raft.components;

//TODO: Will not be change anymore. Change to static?
//But how will it work with the ui manager? Are we fucked up?
public class CompPanelShowControls {
    public Panel Panel;

    // ReSharper disable once ConvertConstructorToMemberInitializers
    public CompPanelShowControls() {
        Panel = new Panel("Some UI here");
    }
}