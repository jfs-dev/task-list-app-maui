using System.ComponentModel.DataAnnotations;
using CommunityToolkit.Mvvm.ComponentModel;

namespace task_list_app_maui.Models;

public class Tarefa : ObservableValidator
{
    private int _id;
    private string _descricao = string.Empty;
    private DateTime _data;
    private TimeSpan _hora;
    private bool _concluida;

    [Key]
    [Required]
    public int Id { get => _id; set => SetProperty(ref _id, value, true); }

    [Required]
    [MaxLength(60)]
    public string Descricao { get => _descricao; set => SetProperty(ref _descricao, value, true); }

    [Required]
    public DateTime Data { get => _data; set => SetProperty(ref _data, value, true); }

    [Required]
    public TimeSpan Hora { get => _hora; set => SetProperty(ref _hora, value, true); }

    [Required]
    public bool Concluida { get => _concluida; set => SetProperty(ref _concluida, value, true); }
}
