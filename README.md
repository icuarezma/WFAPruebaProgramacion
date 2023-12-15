Rama que contiene todo el proyecto es la Rama test

1. En el archivo AMPMContext.cs adecuar la línea número 16 de acuerdo al servidor de ustedes
protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    => optionsBuilder.UseSqlServer("server=ICUAREZMA-IDEAP\\SQLEXPRESS; database=AMPM;Integrated Security=true; TrustServerCertificate=true");

    Cambiar ICUAREZMA-IDEAP\\SQLEXPRESS por el nombre de instancia de su servidor

2. Restaurar el archivo AMPM.bak
