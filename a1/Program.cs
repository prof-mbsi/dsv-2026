using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DbA>(
    options =>
    {
        options.UseSqlite(
            "Data Source=dba.db");
    });

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapGet("/api/a",
    (DbA db) =>
{
    return db.TbA
        .Include(x => x.AtC)
        .ToList();
});

app.MapGet("/api/a/{id}",
    (DbA db, int id) =>
{
    var obj = db.TbA
        .Include(x => x.AtC)
        .FirstOrDefault(
            x => x.AtA == id);

    if (obj == null)
        return Results.NotFound();

    return Results.Ok(obj);
});

app.MapPost("/api/a",
    (DbA db, ClA obj) =>
{
    db.TbA.Add(obj);

    db.SaveChanges();

    return Results.Created(
        $"/api/a/{obj.AtA}",
        obj);
});

app.MapPut("/api/a/{id}",
    (DbA db, int id, ClA dados) =>
{
    var obj = db.TbA.Find(id);

    if (obj == null)
        return Results.NotFound();

    obj.AtB = dados.AtB;

    db.SaveChanges();

    return Results.Ok(obj);
});

app.MapDelete("/api/a/{id}",
    (DbA db, int id) =>
{
    var obj = db.TbA.Find(id);

    if (obj == null)
        return Results.NotFound();

    db.TbA.Remove(obj);

    db.SaveChanges();

    return Results.NoContent();
});

app.MapGet("/api/c",
    (DbA db) =>
{
    return db.TbC.ToList();
});

app.MapPost("/api/a/{id}/b",
    (DbA db, int id, ClB obj) =>
{
    var entidade = db.TbA
        .Include(x => x.AtC)
        .FirstOrDefault(
            x => x.AtA == id);

    if (entidade == null)
        return Results.NotFound();

    entidade.AtC.Add(obj);

    db.SaveChanges();

    return Results.Ok();
});

app.MapGet("/api/a/{id}/resultado",
    (DbA db, int id) =>
{
    var obj = db.TbA
        .Include(x => x.AtC)
        .FirstOrDefault(
            x => x.AtA == id);

    if (obj == null)
        return Results.NotFound();

    return Results.Ok(
        new
        {
            Codigo = obj.AtA,
            Valor = obj.MeA()
        });
});

app.Run();