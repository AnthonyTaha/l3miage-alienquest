namespace AlienQuest.Game.Engine;

public class Animation(int[] frames, float frameTime)
{
    public float FrameTime { get; } = frameTime;
    public int[] Frames { get; } = frames;
}