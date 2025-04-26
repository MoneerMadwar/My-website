var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseDefaultFiles(); // íÎáí ÇáãæŞÚ íİÊÍ index.html ÊáŞÇÆíÇğ
app.UseStaticFiles();  // íÓãÍ ÈÚÑÖ ãáİÇÊ HTML æCSS æJS

app.Run();
