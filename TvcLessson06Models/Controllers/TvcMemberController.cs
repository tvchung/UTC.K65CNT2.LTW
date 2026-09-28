using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TvcLessson06Models.Models;

namespace TvcLessson06Models.Controllers
{
    public class TvcMemberController : Controller
    {
        // mock data
        private static List<TvcMember> _tvcMembers = new List<TvcMember>()
        {
            new TvcMember
            {
                TvcMemberId = Guid.NewGuid().ToString(),
                TvcMemberUserName = "chungtrinh",
                TvcMemberPassword = "123456a@",
                TvcMemberEmail = "chungtrinhj@gmail.com",
                TvcMemberFullName = "Trịnh Văn Chung"
            },

            new TvcMember
            {
                TvcMemberId = Guid.NewGuid().ToString(),
                TvcMemberUserName = "tranthib",
                TvcMemberPassword = "123456",
                TvcMemberEmail = "tranthib@gmail.com",
                TvcMemberFullName = "Trần Thị B"
            },

            new TvcMember
            {
                TvcMemberId = Guid.NewGuid().ToString(),
                TvcMemberUserName = "levanc",
                TvcMemberPassword = "123456",
                TvcMemberEmail = "levanc@gmail.com",
                TvcMemberFullName = "Lê Văn C"
            },

            new TvcMember
            {
                TvcMemberId = Guid.NewGuid().ToString(),
                TvcMemberUserName = "phamthid",
                TvcMemberPassword = "123456",
                TvcMemberEmail = "phamthid@gmail.com",
                TvcMemberFullName = "Phạm Thị D"
            },

            new TvcMember
            {
                TvcMemberId = Guid.NewGuid().ToString(),
                TvcMemberUserName = "hoangvane",
                TvcMemberPassword = "123456",
                TvcMemberEmail = "hoangvane@gmail.com",
                TvcMemberFullName = "Hoàng Văn E"
            }
        };
        // GET: TvcMemberController
        public ActionResult TvcIndex()
        {
            return View(_tvcMembers);
        }

        // GET: TvcMemberController/Details/5
        public ActionResult TvcDetails(string id)
        {
            var tvcMember = _tvcMembers.FirstOrDefault(x=>x.TvcMemberId.Equals(id));    
            return View(tvcMember);
        }

        // GET: TvcMemberController/Create
        public ActionResult TvcCreate()
        {
            return View();
        }

        // POST: TvcMemberController/Create
        [HttpPost]
        public ActionResult TvcCreate(TvcMember tvcMember)
        {
            try
            {
                tvcMember.TvcMemberId=Guid.NewGuid().ToString();
                _tvcMembers.Add(tvcMember);
                return RedirectToAction(nameof(TvcIndex));
            }
            catch
            {
                return View();
            }
        }

        // GET: TvcMemberController/Edit/5
        public ActionResult TvcEdit(string id)
        {
            var tvcMember = _tvcMembers.FirstOrDefault(x => x.TvcMemberId.Equals(id));
            return View(tvcMember);
        }

        // POST: TvcMemberController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TvcEdit(string id, TvcMember tvcMember)
        {
            try
            {
                for (int i = 0; i < _tvcMembers.Count; i++)
                {
                    if (_tvcMembers[i].TvcMemberId.Equals(id))
                    {
                        _tvcMembers[i].TvcMemberFullName = tvcMember.TvcMemberFullName;
                        //...

                        break;
                    }   
                }
                return RedirectToAction(nameof(TvcIndex));
            }
            catch
            {
                return View();
            }
        }

        // GET: TvcMemberController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TvcMemberController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
