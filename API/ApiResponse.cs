using Common;

namespace API;

public class ApiResponse
{
    public string TraceId { get; set; }
    public int Status { get; set; }
    public IEnumerable<Error> Errors { get; set; }
    public object Data { get; set; }
}