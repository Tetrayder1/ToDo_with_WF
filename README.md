<h1 align="center">Salam 👋 Bu WF ToDo tətbiqidir.</h1>
<h3 align="center">Mən bu WF tətbiqində .Net framework dən istifadə etmişəm və bunu sayəsində, codefirst ederek DB tərəfini asanlıqla həll olunub.</h3>
<br/>
<h4 align="left">İstifadə edilən kitabxanalar:</h4>

```c#
Microsoft.EntityFrameworkCore
Microsoft.EntityFrameworkCore.SqlServer
Microsoft.EntityFrameworkCore.Tools
```

<br/>
<h4 align="left">Gəlin kodlari bir-bir gözdən keçirək:</h4>
<hr/>

```c#
  public class DataContext:DbContext
  {
      public DbSet<Todos_table> Todos=>Set<Todos_table>();
      public DbSet<Vision_table> Vision=>Set<Vision_table>();
      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      => optionsBuilder.UseSqlServer();//UseSqlServer() bu metodun içərisinə öz server bağlantınızı yazırsınız
//məsələn:"Server=Server_Name;Database=ToDo;User ID=XXX;Password=YYY;TrustServerCertificate=True;"
  }
```


```c#
public class Vision_table
{
//bu table sayəsində custom  görüntü  vere bilirik
    [Key]
    public int Id { get; set; }
    public string? FontStyle { get; set; }
    public string? TextColor { get; set; }
    public string? BackColor { get; set; }
    public string? TodoListColor { get; set; }
    public string? FindInputBC { get; set; }
    public string? Vision_Name {  get; set; }
    public bool? IsSelected { get; set; }

}

 public class Todos_table
 {
//bu table sayəsində isə todo larimizi yaradiriq .Beleki burada her bir todo ya lazim olan bütün sütünlar var.
    [Key]
    public int Id { get; set; }
    public string? ToDo { get; set; }
    public DateTime DateTime { get; set; }
    public bool IsComplete { get; set; }
 }
```
<h4 align="left">Artıq database tərəfində tables hazirlaya bilərik.Bunun üçün Migration dan faydalanacıq.</h4>

```
 add-migration first_migration
 update-database
//bu kodlari Package Manager Console yazırıq
```

<h4 align="left">Bundan sonra SQL bazasında db və tablelər hazır olur .Yəni artıq əsas metodlar haqqında danışa bilərik.</h4>

```c#
public async void YenileForm(Panel List_panel){}

//Bu metod sayəsində biz form yenilənən zaman onu yenidə yükləməyə kömək edir.
```

```c#
 public async void ListEt(string text = ""){}
//Bu metod bizə yalnız todo lari yeniləməyə imkan verir.
```

```c#
private async void add_button_Click(object sender, EventArgs e)
//Yeni todo əlave edir.
```

```c#
private async void donebutton_Click(object sender, EventArgs e){

var todos = db.Todos.Where(t => t.Id == id).FirstOrDefault();//LİNQ vasitəsilə db -dən məlumat çəkmək
bool iscomplete = todos.IsComplete;
//Bu hissədə əlavə kodlar var.
await db.SaveChangesAsync();//Edilən dəyişikliyi db -ə qeyd etmek 
}
//Bu metod todo -nun edilib edilmədiyini təyin etmə üçündür 
```

```c#
  private async void delete_button_Click(object sender, EventArgs e)
  {
      //s_add_text;
      PictureBox btn = sender as PictureBox;
      Control panel = btn.Parent;
      Control panelList = panel.Parent;
      int id = int.Parse(panel.Name);
      using var db = new DataContext();
      var todos = await db.Todos.Where(table => table.Id == id).FirstOrDefaultAsync();
      db.Remove(todos);//db də silmə prosesi burada kiçik bir kod la həll edirik .Bu da EntityFrameüork -ün sayəsində olur
      await db.SaveChangesAsync();
      ListEt();
  }
//bu metod todo-nu silməyə kömək edir
```

```c#
 private void search_button_Click(object sender, EventArgs e)
 {
     //s_add_text;
     ListEt(s_add_text.Text);//Bura yazilan text təşkil etdiyi text -lərin todo- larini gətirir
 }
//
```

```c#
 private async void con_button_Click(object sender, EventArgs e)
//Config window -unu açırıq
```

<br/>
<hr/>

<h3 align="left">Languages and Tools:</h3>
<p align="left"> <a href="https://www.w3schools.com/cs/" target="_blank" rel="noreferrer"> <img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/csharp/csharp-original.svg" alt="csharp" width="40" height="40"/> </a> <a href="https://dotnet.microsoft.com/" target="_blank" rel="noreferrer"> <img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/dot-net/dot-net-original-wordmark.svg" alt="dotnet" width="40" height="40"/> </a> <a href="https://git-scm.com/" target="_blank" rel="noreferrer"> <img src="https://www.vectorlogo.zone/logos/git-scm/git-scm-icon.svg" alt="git" width="40" height="40"/> </a> <a href="https://www.microsoft.com/en-us/sql-server" target="_blank" rel="noreferrer"> <img src="https://www.svgrepo.com/show/303229/microsoft-sql-server-logo.svg" alt="mssql" width="40" height="40"/> </a> </p>

<h3 align="left">Connect with me:</h3>
<p align="left">
<a href="https://linkedin.com/in/linkedin.com/in/amid-abdullayev" target="blank"><img align="center" src="https://raw.githubusercontent.com/rahuldkjain/github-profile-readme-generator/master/src/images/icons/Social/linked-in-alt.svg" alt="linkedin.com/in/amid-abdullayev" height="30" width="40" /></a>
</p>
