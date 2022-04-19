using Microsoft.EntityFrameworkCore;

namespace BlazorResearchTool.Server.Data;

public class ResearchToolDbContext : DbContext
{
    public ResearchToolDbContext(DbContextOptions<ResearchToolDbContext> options) : base((options))
    {
        
    }
    
    
    
}