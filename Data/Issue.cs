using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static FormEnums;

namespace DataKodBlazorServer.Data
{
    public class Issue
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set;}
        public string FirstName {get;set;}
        public string LastName {get;set;}
        public string Email {get;set;}
        public TicketType ticket {get; set;}
        public Priority priority{get; set;}
        public string Browser {get;set;}
        public string BrowserVersion {get;set;}
        public string OperatingSystem {get;set;}
        public string OSVersion {get;set;}
        public string File {get;set;}
        public string Details {get;set;}
        
    }
}