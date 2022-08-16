using AirlineTicketing.Model;
using AirlineTicketing.Dao;
using Microsoft.AspNetCore.Mvc;

namespace AirlineTicketing.Service {
    /// <summary>
    /// �û� ����� �ӿ�
    /// </summary>
    public interface IUserService {
        /// <summary>
        /// ��ȡ�����û�
        /// </summary>
        /// <returns>�û�List</returns>
        public IEnumerable<User> GetUsers();
    }


    /// <summary>
    /// �û� ����� �ӿ�ʵ��
    /// </summary>
    public class UserService : IUserService {
        /// <summary>
        /// Dao�� ����
        /// </summary>
        private readonly UserDao userDao = new UserDao();

        /// <summary>
        /// ��ȡ�����û�
        /// </summary>
        /// <returns>�û������б�</returns>
        public IEnumerable<User> GetUsers() {
            return userDao.GetList().ToList();
        }

        /// <summary>
        /// ��Id��ѯ�û�
        /// </summary>
        /// <param name="id">�û�Id</param>
        /// <returns>�û�����</returns>
        public User GetUserById(string id) {
            return userDao.GetById(id);
        }

        /// <summary>
        /// ������ɾ���û�
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public bool DeleteUserByIds([FromBody] object[] ids) {
            return userDao.DeleteById(ids);
        }

        /// <summary>
        /// ��� 
        /// </summary>
        /// <returns></returns>
        public bool Add([FromBody] User data) {
            return userDao.Insert(data);
        }

        /// <summary>
        /// �޸�
        /// </summary>
        /// <returns></returns>
        public bool Update([FromBody] User data) {
            return userDao.Update(data);
        }
    }
}