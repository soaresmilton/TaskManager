﻿namespace TaskManager.Communication.Responses;
public class ResponseCreatedTaskJson
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

}
