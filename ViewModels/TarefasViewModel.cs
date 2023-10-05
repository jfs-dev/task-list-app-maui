using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using System.Data;
using task_list_app_maui.Data;
using task_list_app_maui.Models;

namespace task_list_app_maui.ViewModels;

public partial class TarefasViewModel : ObservableObject, IDisposable
{
    protected readonly AppDbContext _context;

    public ObservableCollection<Tarefa> TarefasPendentes { get ; set ; } = new();
    public ObservableCollection<Tarefa> TarefasConcluidas { get ; set ; } = new();

    [ObservableProperty]
    public Tarefa tarefa = new();

    public Tarefa TarefaEditMode { get ; set ; } = new();

    [ObservableProperty]
    public string hasErrorsCodeBehind = string.Empty;

    public TarefasViewModel()
    {
        _context = new AppDbContext();
    }

    [RelayCommand]
    public void New()
    {
        Tarefa = new()
        {
            Data = DateTime.Today,
            Hora = DateTime.Now.TimeOfDay
        };
    }

    [RelayCommand]
    public void EditModeOn()
    {
        TarefaEditMode.Id = Tarefa.Id;
        TarefaEditMode.Descricao = Tarefa.Descricao;
        TarefaEditMode.Data = Tarefa.Data;
        TarefaEditMode.Hora = Tarefa.Hora;
        TarefaEditMode.Concluida = Tarefa.Concluida;
    }

    [RelayCommand]
    public void EditModeOff()
    {
        Tarefa.Id = TarefaEditMode.Id;
        Tarefa.Descricao = TarefaEditMode.Descricao;
        Tarefa.Data = TarefaEditMode.Data;
        Tarefa.Hora = TarefaEditMode.Hora;
        Tarefa.Concluida = TarefaEditMode.Concluida;
    }

    [RelayCommand]
    public void Create()
    {
        try
        {
            HasErrorsCodeBehind = string.Empty;

            _context.Entry(Tarefa).State = EntityState.Added;
            _context.SaveChanges();
        }
        catch (System.Exception ex)
        {
            HasErrorsCodeBehind = ex.Message;
        }
    }

    [RelayCommand]
    public void Edit()
    {
        try
        {
            HasErrorsCodeBehind = string.Empty;

            _context.Entry(Tarefa).State = EntityState.Modified;
            _context.SaveChanges();
            
            EditModeOn();
        }
        catch (System.Exception ex)
        {
            HasErrorsCodeBehind = ex.Message;
        }
    }

    [RelayCommand]
    public void Delete()
    {
        try
        {
            HasErrorsCodeBehind = string.Empty;

            _context.Entry(Tarefa).State = EntityState.Deleted;
            _context.SaveChanges();
        }
        catch (System.Exception ex)
        {
            HasErrorsCodeBehind = ex.Message;
        }
    }

    [RelayCommand]
    public void GetAll()
    {
        TarefasPendentes.Clear();

        foreach (var tarefa in _context.Tarefas.Where(x => x.Concluida == false).OrderBy(x => x.Data + x.Hora).ToList())
            TarefasPendentes.Add(tarefa);
        
        TarefasConcluidas.Clear();

        foreach (var tarefa in _context.Tarefas.Where(x => x.Concluida == true).OrderByDescending(x => x.Data + x.Hora).ToList())
            TarefasConcluidas.Add(tarefa);
    }    

    public void Dispose() => _context.Dispose();
}
