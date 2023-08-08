using TEAMGE_API.Models;


List<Comment> CommentList = new List<Comment>()
{
    new Comment()
    {
        Id = 1,
        AuthorId = 1,
        PostId = 1,
        Content = "Web3 looks promising!"
    },
    new Comment()
    {
        Id = 2,
        AuthorId = 2,
        PostId = 3,
        Content = "OpenAI has a new competitor.. Let's see who can make the best AI."
    },
    new Comment()
    {
        Id = 3,
        AuthorId = 3,
        PostId = 3,
        Content = "Google servers are down! Mass DDOS attack!!"
    },
    new Comment()
    {
        Id = 4,
        AuthorId = 4,
        PostId = 4,
        Content = "How the fuck did Google let themselves get hacked?! Idiots."
    },
    new Comment()
    {
        Id = 5,
        AuthorId = 5,
        PostId = 5,
        Content = "New DevMode in Figma is sick!"
    },
    new Comment()
    {
        Id = 5,
        AuthorId = 4,
        PostId = 5,
        Content = "LOL OpenAI is better without Elon."
    },
};

List<Category> CategoryList = new List<Category>()
{
    new Category()
    {
        Id = 1,
        Label = "Crypto/Web3",
    },
    new Category()
    {
        Id = 2,
        Label = "Web Development",
    },
    new Category()
    {
        Id = 3,
        Label = "AI",
    },
    new Category()
    {
        Id = 4,
        Label = "CyberSecurity",
    },
    new Category()
    {
        Id = 5,
        Label = "UI/UX",
    },
};


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
