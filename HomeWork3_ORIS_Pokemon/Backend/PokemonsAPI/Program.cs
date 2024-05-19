using PokemonsAPI.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    var xmlPath = string.Format(@"{0}PokemonsAPI.xml", AppDomain.CurrentDomain.BaseDirectory);
    options.IncludeXmlComments(xmlPath);
});
builder.Services.AddCors(options =>
{
    options
        .AddPolicy(
            "AllowAnyOrigin",
            opt => opt.AllowAnyOrigin());
});

builder.Services.AddHttpClient();
builder.Services.AddScoped<IPokeService, PokeService>();
builder.Services.AddLogging();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseCors("AllowAnyOrigin");

app.UseAuthorization();
app.MapControllers();

app.Run();