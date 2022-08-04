namespace NetCore6
{
    public class FrontMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            Console.Clear();
            Console.WriteLine("FrontMiddleware: " + context.Request.Path);
            await next(context);
        }
    }
}
