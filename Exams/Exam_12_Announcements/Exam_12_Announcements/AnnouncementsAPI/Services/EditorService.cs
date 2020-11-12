﻿using AnnouncementsApp.Data;
using AnnouncementsApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
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

        internal void LoadListOfAnnouncement()
        {
            
            var announcements = _context.Announcements.ToList();
            foreach (var announcement in announcements)
            {
                Console.WriteLine($" {announcement.Id}   {announcement.Tittle}\n" +
                                        $"     {announcement.Description}    {announcement.DateAdded}");
                Console.WriteLine();
            }
        }

        internal void DeleteAnnoucement()
        {
            var id = 0;
            var inputId = RequstInputToDelete();
            var isInteger = Int32.TryParse(inputId, out id);
            
            while(!IsInputValid(isInteger, id))
            {
                inputId = RequstInputToDelete();
                isInteger = Int32.TryParse(inputId, out id);
            }
                

            var announcement = _context.Announcements.FirstOrDefault(a => a.Id == id);
            _context.Announcements.Remove(announcement);
            _context.SaveChanges();
        }

        private string RequstInputToDelete()
        {
            Console.WriteLine();
            Console.WriteLine($"There are {_context.Announcements.Count()} of announcements!");
            Console.Write($"Choose Id of announcement, which you want to delete: ");
            var inputId = Console.ReadLine();
            return inputId;
        }

        private bool IsInputValid(bool isInteger, int id)
        {

            if (!isInteger)
            {
                Console.WriteLine("Number should be an integer value");
                return false;
            }

            if (!_context.Announcements.Any(i => i.Id == id))
            {
                Console.WriteLine($"The Id doesn't exists please try again");
                return false;
            }

            return true;
        }




        /*public void EnsureCreatingDatabase()
        {
            _context.Database.EnsureCreated();
        }*/
    }
}
