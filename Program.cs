using CarBuilder.Models;

List<PaintColor> paintColors = new List<PaintColor>()
{
    new PaintColor
    {
        Id = 1,
        Price = 200M,
        Color = "Silver"
    },
    new PaintColor
    {
        Id = 2,
        Price = 220M,
        Color = "Midnight Blue"
    },
    new PaintColor
    {
        Id = 3,
        Price = 240M,
        Color = "Firebrick Red"
    },
    new PaintColor
    {
        Id = 4,
        Price = 250M,
        Color = "Spring Green"
    }
};

List<Interior> interiors = new List<Interior>()
{
    new Interior
    {
        Id = 1,
        Price = 500M,
        Material = "Biege Fabric"
    },
    new Interior
    {
        Id = 2,
        Price = 510M,
        Material = "Charcoal Fabric"
    },
    new Interior
    {
        Id = 1,
        Price = 550M,
        Material = "White Leather"
    },
    new Interior
    {
        Id = 1,
        Price = 550M,
        Material = "Black Leather"
    }
};


var builder = WebApplication.CreateBuilder(args);

// Configure Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Enable Swagger in development
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Add your API endpoints here



app.Run();