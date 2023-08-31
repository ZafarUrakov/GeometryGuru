namespace GeometryGuru.Interfaces;

public interface IReport
{
    public int FormatExceptionMessage();
    public void ResultProgress();
    public void DefaultProgress();
    public void Exit();
}