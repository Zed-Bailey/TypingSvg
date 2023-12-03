using System.ComponentModel.DataAnnotations;

namespace TypingSvg.Models;

public class TypingViewModel
{
    [Required]
    public int Width { get; set; }
    
    [Required]
    public int Height { get; set; }

    [Required]
    public string? Lines;
    
    public string BackgroundColour { get; set; } = "00000000";

    public string FontColour { get; set; } = "36BCF7";
    public bool Repeat { get; set; } = true;

    public int Duration { get; set; } = 5000;
    
    public int Pause { get; set; } = 1000;

    public bool HCenter { get; set; } = false;
    public bool VCenter { get; set; } = false;

    public int FontSize { get; set; } = 20;
}