using AnnouncementsApp.Data;
using AnnouncementsApp.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnnouncementsAPI.Services
{
    class EditorService
    {
        public AnnouncementContext _context = new AnnouncementContext();

        
        public void AddAnnouncement()
        {
            EnsureCreatingDatabase();
            var announcement = new Announcement ( "Dinner", "Tasty dinner", DateTime.Now);
            _context.Announcements.Add(announcement);
            _context.SaveChanges();
        }

        public void EnsureCreatingDatabase()
        {
            _context.Database.EnsureCreated();
        }
    }
}
