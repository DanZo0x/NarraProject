namespace TCG.Core.Dialogues
{
    public class TextCommandsFactory
    {
        public TextCommand CreateCommand(string commandName)
        {
            switch (commandName) {
                case "pause":
                case "p":
                    return new TextCommandPause();
                case "camshake": return new TextCommandCameraShake();
                case "textshake": return new TextCommandTextShake();
            }

            return null;
        }
    }
}