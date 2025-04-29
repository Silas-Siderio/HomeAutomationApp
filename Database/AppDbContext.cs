using SQLite;
using HomeAutomationApp.Models;

namespace HomeAutomationApp.Database
{
    public class AppDbContext
    {
        private readonly SQLiteAsyncConnection _database;

        public AppDbContext(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<DeviceModel>().Wait();
        }

        public Task<List<DeviceModel>> GetDevicesAsync()
        {
            return _database.Table<DeviceModel>().ToListAsync();
        }

        public Task<int> SaveDeviceAsync(DeviceModel device)
        {
            if (device.Id != 0)
                return _database.UpdateAsync(device);
            else
                return _database.InsertAsync(device);
        }

        public Task<int> DeleteDeviceAsync(DeviceModel device)
        {
            return _database.DeleteAsync(device);
        }
    }
}