
using Microsoft.EntityFrameworkCore;

namespace G26W09WFSnackList;

public class Database : DbContext {
    public DbSet<Snack> Tuples { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        // snacks.db 파일로 저장
        optionsBuilder.UseSqlite("Data Source=snacks.db");
    }

    public void AddInitSnack() {
        Tuples.AddRange(new Snack[] {
            new("어묵", "하루 과제 4과목 스트레스", "https://images.unsplash.com/photo-1724861836718-d8443baa0f82?q=80&w=1170&auto=format&fit=crop&ixlib=rb-4.1.0&ixid=NHwxMjA3fDA%3D"),
            new("초밥", "순대 찾는데 한개도 안나옴", "https://pokemonkorea.co.kr/public-assets/home/data/data1_www/newdata/pokedex/mid/097801.png"),
            new("빅아치버거", "랩 들으니 먹고싶음", "https://www.mcdonalds.co.kr/upload/2026/10/Corp_PC_VIEW_772x530_%EB%B9%85%EC%95%84%EC%B9%98_EVM.png"),
            new("감바스 짜파게티", "버스 예약 실패", "https://cafe24img.poxo.com/nsmall2022/web/product/big/202610/a71242bf65da9354fc10588f906cf116.jpg"),
            new("고추바사삭 치킨", "중간고사 보고 멘탈 바사삭", "https://images.unsplash.com/photo-1578874557108-9fc2cfb1121e?w=600&auto=format&fit=crop&q=60&ixlib=rb-4.1.0&ixid=NHwxMjA3fDA%3D"),
            new("아이스크림", "음료수 주머니에 넣고 집가는데 도착하니 잃어버림", "https://plus.unsplash.com/premium_photo-1690440686714-c06a56a1511c?w=600&auto=format&fit=crop&q=60&ixlib=rb-4.1.0&ixid=NHwxMjA3fDA%3D"),
            new("공차 밀크티", "과제 제출하면 과제 리필", "https://images.unsplash.com/photo-1761673930163-8d3d6d73cd7a?w=600&auto=format&fit=crop&q=60&ixlib=rb-4.1.0&ixid=NHwxMjA3fDA%3D"),
            new("망고", "늦잠자서 수업 결석(기분 괜찮음)", "https://plus.unsplash.com/premium_photo-1724255863045-2ad716767715?w=600&auto=format&fit=crop&q=60&ixlib=rb-4.1.0&ixid=NHwxMjA3fDA%3D"),
            new("족발", "버스안에서 깜빡 졸아서 종점 도착", "https://images.unsplash.com/photo-1688084403060-3594a4b8ff8d?w=600&auto=format&fit=crop&q=60&ixlib=rb-4.1.0&ixid=NHwxMjA3fDA%3D"),
            new("피자", "코딩 과제 컴파일 에러 100개 돌파", "https://images.unsplash.com/photo-1513104890138-7c749659a591?w=600&auto=format&fit=crop&q=60&ixlib=rb-4.1.0&ixid=NHwxMjA3fDA%3D"),
            new("곱창", "발표 직전에 배아픔", "https://images.unsplash.com/photo-1697862445339-807e9a79b4d6?w=600&auto=format&fit=crop&q=60&ixlib=rb-4.1.0&ixid=NHwxMjA3fDA%3D"),
            new("김밥", "학교 왔더니 공강", "https://plus.unsplash.com/premium_photo-1712949141720-6ddee2bde0bf?w=600&auto=format&fit=crop&q=60&ixlib=rb-4.1.0&ixid=NHwxMjA3fDA%3D"),
            new("삼겹살", "정답이 아닌걸 알면서도 내야함", "https://images.unsplash.com/photo-1785735011447-9942c0ba0b13?w=600&auto=format&fit=crop&q=60&ixlib=rb-4.1.0&ixid=NHwxMjA3fDA%3D"),
            new("붕어빵", "휴일에 4시에 일어나서 일찍 놀아야지 했는데 오후 4시", "https://images.unsplash.com/photo-1673188979255-e08a5791d193?w=600&auto=format&fit=crop&q=60&ixlib=rb-4.1.0&ixid=NHwxMjA3fDA%3D"),
            new("핫도그", "과제 저장 못했는데 갑자기 정전", "https://images.unsplash.com/photo-1638368593249-7cadb261e8b3?w=600&auto=format&fit=crop&q=60&ixlib=rb-4.1.0&ixid=NHwxMjA3fDA%3D"),
            new("초코바", "휴일이면 꼭 일이 생김", "https://images.unsplash.com/photo-1621939514649-280e2ee25f60?w=600&auto=format&fit=crop&q=60&ixlib=rb-4.1.0&ixid=NHwxMjA3fDA%3D"),
            new("라면", "연락하라해서 연락했더니 연락이 안옴", "https://plus.unsplash.com/premium_photo-1694708455263-e58c7aacbb19?w=600&auto=format&fit=crop&q=60&ixlib=rb-4.1.0&ixid=NHwxMjA3fDA%3D"),
            new("삶은 계란", "헬스장 갔더니 휴일", "https://plus.unsplash.com/premium_photo-1677674543337-42e647e24316?w=600&auto=format&fit=crop&q=60&ixlib=rb-4.1.0&ixid=NHwxMjA3fDA%3D"),
            new("된장국", "군대 휴가 나왔는데 계엄령", "https://images.unsplash.com/photo-1744116927815-a04ba6629cf3?w=600&auto=format&fit=crop&q=60&ixlib=rb-4.1.0&ixid=NHwxMjA3fDA%3D"),
            new("케이크", "종강 맞이 기념", "https://images.unsplash.com/photo-1606890737304-57a1ca8a5b62?w=600&auto=format&fit=crop&q=60&ixlib=rb-4.1.0&ixid=NHwxMjA3fDA%3D")
        });

        // 실제로 데이터베이스에 저장
        SaveChanges();
    }
}
