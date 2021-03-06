﻿using System;
using System.Data.Entity;
using System.Linq;
using Todo.Core.Database.Tables;
using Todo.Data;

namespace Todo.Service
{
    public class TaskService : BaseService
    {
        public TaskService(TodoContext context)
        {
            _context = context;
        }

        #region tasks
        public void AddTask(tblTask task)
        {
            _context.tblTasks.Add(task);
        }

        public IQueryable<tblTask> GetAllTasks()
        {
            var tasks = _context.tblTasks;

            return tasks;
        }

        public tblTask FindTask(int id)
        {
            var task = _context.tblTasks.Find(id);

            return task;
        }

        public void DeleteTask(tblTask task)
        {
            _context.tblTasks.Attach(task);
            _context.Entry(task).State = EntityState.Deleted;
        }
        #endregion

        #region groups
        public IQueryable<tblGroup> GetAllGroups()
        {
            var groups = _context.tblGroups;

            return groups;
        }

        public void AddGroup(tblGroup group)
        {
            _context.tblGroups.Add(group);
        }

        public tblGroup FindGroup(int groupId)
        {
            var group = _context.tblGroups.Find(groupId);

            return group;
        }

        public void DeleteGroup(tblGroup groupToDelete)
        {
            _context.tblGroups.Attach(groupToDelete);
            _context.Entry(groupToDelete).State = EntityState.Deleted;
        }


        #endregion
    }
}
