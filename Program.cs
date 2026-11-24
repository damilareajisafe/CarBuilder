using CarBuilder.Models;
using CarBuilder.Models.DTO;

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
        Id = 3,
        Price = 550M,
        Material = "White Leather"
    },
    new Interior
    {
        Id = 4,
        Price = 550M,
        Material = "Black Leather"
    }
};

List<Technology> technologies = new List<Technology>()
{
    new Technology
    {
        Id = 1,
        Price = 1000M,
        Package = "Basic Package"
    },
    new Technology
    {
        Id = 2,
        Price = 1500M,
        Package = "Navigation Package"
    },
    new Technology
    {
        Id = 3,
        Price = 2000M,
        Package = "Visibility Package"
    },
    new Technology
    {
        Id = 4,
        Price = 2500M,
        Package = "Ultra Package"
    }
};

List<Wheels> wheels = new List<Wheels>()
{
    new Wheels
    {
        Id = 1,
        Price = 800M,
        Style = "17-inch Pair Radial"
    },
    new Wheels
    {
        Id = 2,
        Price = 900M,
        Style = "17-inch Pair Radial Black"
    },
    new Wheels
    {
        Id = 3,
        Price = 1000M,
        Style = "18-inch Pair Spoke Silver"
    },
    new Wheels
    {
        Id = 4,
        Price = 1100M,
        Style = "18-inch Pair Spoke Black"
    }
};

List<Order> orders = new List<Order>() { };

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

app.MapGet("/wheels", () =>
{
    return wheels.Select(w => new WheelsDTO
    {
        Id = w.Id,
        Price = w.Price,
        Style = w.Style
    });
});

app.MapGet("/wheels/{id}", (int id) =>
{
    Wheels wheel = wheels.FirstOrDefault(w => w.Id == id);

    if (wheel == null)
    {
        return Results.NotFound();
    }

    return Results.Ok(new WheelsDTO
    {
        Id = wheel.Id,
        Price = wheel.Price,
        Style = wheel.Style
    });
});

app.MapGet("/technologies", () =>
{
    return technologies.Select(t => new TechnologyDTO
    {
        Id = t.Id,
        Price = t.Price,
        Package = t.Package
    });
});

app.MapGet("/technologies/{id}", (int id) =>
{
    Technology technology = technologies.FirstOrDefault(t => t.Id == id);

    if (technology == null)
    {
        return Results.NotFound();
    }

    return Results.Ok(new TechnologyDTO
    {
        Id = technology.Id,
        Price = technology.Price,
        Package = technology.Package
    });
});


app.Run();