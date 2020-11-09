using AnnouncementsApp.Data;
using AnnouncementsApp.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnnouncementsAPI.Services
{
    class EditorService
    {
        public string InputTittle { get; set; }
        public string InputDescription { get; set; }
        public AnnouncementContext _context = new AnnouncementContext();

        
        public void AddAnnouncement()
        {
            GetInputOfAnnouncement();
            var announcement = new Announcement ( InputTittle, InputDescription);
            _context.Announcements.Add(announcement);
            _context.SaveChanges();
        }

        private void GetInputOfAnnouncement()
        {
            Console.WriteLine();
            Console.Write("Enter tittle of announcement: ");
            var inputTittle = Console.ReadLine();
            InputTittle = inputTittle;
            Console.WriteLine();
            Console.Write("Enter description of announcement: ");
            var inputDescription = Console.ReadLine();
            InputDescription = inputDescription;
        }

        public void EditAnnouncement()
        {
            FindAnnouncement();
        }

        private void FindAnnouncement()
        {
            
        }

        /*public void EnsureCreatingDatabase()
        {
            _context.Database.EnsureCreated();
        }*/
    }
}
