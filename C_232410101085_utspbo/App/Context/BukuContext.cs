using C_232410101085_utspbo.App.Core;
using Npgsql;
using System;
using Npgsql;
using NpgsqlTypes;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_232410101085_utspbo.App.Model;
using C_232410101085_utspbo.View;


namespace C_232410101085_utspbo.App.Context
{
    internal class BukuContext : DatabaseWrapper
    {
        private static string table = "judul_buku";
        public static DataTable All()
        {
            string query = @"SELECT id_buku, judul_buku, tahun_terbit";
            DataTable dataBuku = queryExecutor(query);
            return dataBuku;
        }
        public static DataTable getBukuById(int id)
        {
            string query = @"SELECT id_buku, judul_buku, tahun_terbit";
        }
        NpgsqlParameter[] parameters =
        {
            new NpgsqlParameter("@id",NpgsqlTypes.NpgsqlDbType.Integer) { Value = id }
        };
        DataTable dataBuku = queryExecutor(query,parameters);
        return dataBuku;
    }
    public static void AddBuku(M_Buku addBuku)
    {
        string query = $"INSERT INTO {table}(Judul_Buku, Pengarang, Tahun_Terbit) VALUES (@Judul_Buku, @Pengarang, @Tahun_Terbit);";
        NpgsqlParameter[] parameters =
        {
            new NpgsqlParameter("@nama", addBuku.judul_buku),
            new NpgsqlParameter("@nim", addBuku.penerbit),
            new NpgsqlParameter("@email", addBuku.tahun_terbit),
        };
        commandExecutor(query, parameters);
    }
    public static void UpdateBuku(M_Buku buku)
    {
        string query = $"UPDATE {table} SET Judul_Buku = @Judul_Buku, Pengarang = @Pengarang, Tahun_Terbit = @Tahun_Terbit WHERE id_buku = @id";
        NpgsqlParameter[] parameters =
        {
            new NpgsqlParameter("@nama", buku.judul_buku),
            new NpgsqlParameter("@nim", buku.penerbit),
            new NpgsqlParameter("@email", buku.tahun_terbit),
        };
        commandExecutor(query, parameters);
    }
    public static void DeleteMahasiswa(int id)
    {
        string query = $"DELETE FROM {table} WHERE id = @id";
        NpgsqlParameter[] parameters =
        {
            new NpgsqlParameter("@id", id)

        };
        commandExecutor(query, parameters);
    }
}
