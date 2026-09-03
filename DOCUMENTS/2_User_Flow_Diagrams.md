# User Flow & Architecture Diagrams
## Nền Tảng Hạt Dẻ Comic

---

## 📊 1. User Flow: Nạp Hạt Dẻ → Tiêu Dùng → Đọc VIP

```mermaid
graph TD
    A["🏠 Trang Chủ<br/>Độc giả"] --> B{Đã có<br/>Hạt dẻ?}
    
    B -->|Không| C["💰 Ví Hạt Dẻ<br/>Số dư: 0"]
    B -->|Có| C
    
    C --> D{Chọn cách<br/>nạp?}
    
    D -->|Check-in hàng ngày| E["✅ Check-in<br/>+5 Hạt dẻ"]
    D -->|Referral| F["👥 Giới thiệu<br/>Bạn +50<br/>Được mời +50"]
    D -->|Mua trực tiếp| G["💳 Chọn gói nạp"]
    D -->|Giftcode| H["🎁 Nhập Code"]
    
    E --> I["💰 Ví: +5 Hạt dẻ"]
    F --> I
    G --> J["Thanh toán<br/>VNĐ/USD"]
    J --> K["✅ Thành công"]
    K --> I
    H --> L{Code<br/>hợp lệ?}
    L -->|Có| M["💰 Nhận phần thưởng"]
    L -->|Không| N["❌ Lỗi - Thử lại"]
    M --> I
    
    I --> O["👀 Xem truyện VIP<br/>Giá: 10 Hạt dẻ/chương"]
    O --> P{Đủ Hạt dẻ?}
    
    P -->|Không| Q["⚠️ Nạp thêm?"]
    Q -->|Yes| D
    Q -->|No| R["📖 Đọc chương miễn phí"]
    
    P -->|Có| S["🔓 Mở khóa chương"]
    S --> T["💰 Ví: -10 Hạt dẻ"]
    T --> U["📖 Đọc chương VIP"]
    U --> V["🎉 Lưu tiến độ<br/>Unlock achievement?"]
    
    R -.-> W["👤 Profile<br/>Tủ sách<br/>Lịch sử"]
    U -.-> W
    V -.-> W
    
    W --> X["📊 Dashboard<br/>Hạt dẻ, Truyện, Điểm"]
    
    style A fill:#E8A080
    style C fill:#FFF8DC
    style I fill:#FFE4B5
    style U fill:#90EE90
    style V fill:#87CEEB
```

---

## 👤 2. User Flow: Creator (Tác Giả) - Quản Lý Truyện & Doanh Thu

```mermaid
graph TD
    A["👨‍✍️ Tác Giả<br/>Đăng nhập"] --> B["📚 Dashboard Tác Giả"]
    
    B --> C{Hành động?}
    
    C -->|Viết chương mới| D["✏️ Trình soạn thảo<br/>WYSIWYG"]
    C -->|Quản lý truyện| E["🔧 Cài đặt Truyện"]
    C -->|Tạo code| F["🎁 Tạo Giftcode<br/>Hàng loạt"]
    C -->|Xem doanh thu| G["📊 Analytics<br/>& Reports"]
    C -->|Affiliate| H["🔗 Quản lý Link<br/>Affiliate"]
    
    D --> D1["📝 Viết nội dung<br/>+ Hình ảnh<br/>+ Link"]
    D1 --> D2["👁️ Preview"]
    D2 --> D3{Chế độ?}
    D3 -->|Miễn phí| D4["🆓 Công khai<br/>ngay lập tức"]
    D3 -->|VIP| D5["🔒 Đặt giá<br/>5-100 Hạt dẻ"]
    D4 --> D6["📤 Đăng chương"]
    D5 --> D6
    D6 --> D7["✅ Chương live<br/>Độc giả có thể mở khóa"]
    
    E --> E1["⚙️ Cài đặt truyện<br/>Thể loại, Mô tả<br/>Bìa, Tags"]
    E1 --> E2["💰 Quản lý giá<br/>VIP mặc định"]
    E2 --> E3["✅ Lưu"]
    
    F --> F1["🔢 Chỉ định:<br/>Số lượng<br/>Phần thưởng<br/>Thời hạn"]
    F1 --> F2["⏱️ Thời gian sử dụng<br/>Một lần / Nhiều lần"]
    F2 --> F3["📥 Tạo & Tải về<br/>CSV"]
    
    G --> G1["📈 Biểu đồ<br/>Lượt xem hàng ngày<br/>Mở khóa/tuần"]
    G1 --> G2["💵 Doanh thu<br/>Từ VIP chapters<br/>Top chapters<br/>Top readers (donors)"]
    G2 --> G3["🎯 Insights<br/>Giờ peak<br/>Thể loại yêu thích"]
    
    H --> H1["🎨 Chọn widget<br/>Banner/Text/Button"]
    H1 --> H2["🔀 Vị trí<br/>Đầu chương<br/>Giữa nội dung<br/>Cuối chương"]
    H2 --> H3["📊 Theo dõi<br/>CTR, Conversion<br/>Commission"]
    
    D7 -.-> I["👥 Độc giả mua<br/>Hạt dẻ -X<br/>Tác giả +Y"]
    G2 -.-> I
    
    I --> J["💰 Thống kê tác giả<br/>Tổng doanh thu<br/>Rút tiền<br/>Lịch sử"]
    
    style A fill:#E8A080
    style B fill:#FFF8DC
    style D7 fill:#90EE90
    style J fill:#FFB6C1
```

---

## 🛠️ 3. User Flow: Admin - Quản Lý Platform

```mermaid
graph TD
    A["👨‍💼 Admin<br/>Đăng nhập"] --> B["🎛️ Admin Dashboard"]
    
    B --> C{Quản lý?}
    
    C -->|Người dùng| D["👥 Quản lý Người Dùng"]
    C -->|Nội dung| E["📄 Duyệt Nội Dung"]
    C -->|Tiền| F["💰 Quản lý Hạt dẻ"]
    C -->|Báo cáo| G["📊 Analytics Platform"]
    
    D --> D1["🔍 Tìm kiếm người dùng<br/>Email/ID/Username"]
    D1 --> D2{Hành động?}
    D2 -->|Khóa tài khoản| D3["🚫 Vô hiệu hóa<br/>Lý do: Vi phạm"]
    D2 -->|Xem hoạt động| D4["📋 Lịch sử login<br/>Giao dịch, Bình luận"]
    D2 -->|Thông báo| D5["📢 Gửi thông báo<br/>Hàng loạt/1-1"]
    D3 --> D6["✅ Tác vụ hoàn thành"]
    
    E --> E1["⏳ Truyện chờ phê duyệt<br/>Danh sách gồi tất cả"]
    E1 --> E2{Kiểm duyệt}
    E2 -->|✅ Phê duyệt| E3["✓ Công khai truyện"]
    E2 -->|❌ Từ chối| E4["📝 Lý do từ chối<br/>Gửi email tác giả"]
    E2 -->|⚠️ Cảnh báo| E5["🚨 Cảnh báo tác giả<br/>Vi phạm nội dung"]
    
    E3 --> E6["📢 Truyện live<br/>Xuất hiện trong tìm kiếm"]
    E4 --> E7["✉️ Tác giả nhận lý do<br/>Có thể sửa đổi"]
    
    F --> F1["💳 Nạp Hạt dẻ<br/>Hỗ trợ người dùng"]
    F1 --> F2["Chọn người dùng<br/>+ Số lượng Hạt dẻ"]
    F2 --> F3["✅ Thêm vào ví"]
    
    F --> F4["🔑 Tạo Code Hàng Loạt<br/>Thường cho sự kiện"]
    F4 --> F5["Số lượng, Phần thưởng<br/>Thời hạn"]
    F5 --> F6["📥 Tải về CSV<br/>Phân phối"]
    
    G --> G1["📈 Tổng Quát<br/>DAU, MAU<br/>Doanh thu<br/>Retention rate"]
    G1 --> G2["🔝 Top Metrics<br/>Top truyện<br/>Top tác giả<br/>Top readers"]
    G2 --> G3["💹 Xu hướng<br/>Growth rate<br/>Churn rate<br/>ARPU"]
    
    D6 -.-> H["🎯 Hệ thống<br/>hoạt động bình thường"]
    E6 -.-> H
    F3 -.-> H
    G3 -.-> H
    
    style A fill:#E8A080
    style B fill:#FFF8DC
    style D6 fill:#90EE90
    style H fill:#87CEEB
```

---

## 🎯 4. Payment Flow - Nạp Hạt Dẻ (Trình Tự Chi Tiết)

```mermaid
graph TD
    A["Người dùng<br/>Vào Ví Hạt dẻ"] --> B["Chọn gói nạp<br/>Starter-Elite"]
    
    B --> C["💳 Thanh toán<br/>Gateway"]
    
    C --> D{Phương thức?}
    
    D -->|Visa/MC| E["Stripe/Paypal<br/>API"]
    D -->|Momo/ZaloPay| F["Momo/ZaloPay<br/>API"]
    D -->|Ngân hàng| G["VNPay<br/>API"]
    
    E --> H["🔐 Verify 3D Secure<br/>hoặc OTP"]
    F --> H
    G --> H
    
    H --> I{Thành công?}
    
    I -->|✅ Thành công| J["💰 Cộng Hạt dẻ<br/>vào ví người dùng"]
    I -->|❌ Thất bại| K["❌ Thông báo lỗi<br/>Thử lại hoặc hủy"]
    
    J --> L["📧 Email xác nhận<br/>Mã giao dịch<br/>Số lượng Hạt dẻ<br/>Giá"]
    
    L --> M["✅ Hoàn thành<br/>Người dùng sẵn sàng<br/>mua VIP chapters"]
    
    K --> N["User có thể<br/>Thử lại hoặc<br/>Chọn phương thức khác"]
    
    N -.-> C
    
    style A fill:#E8A080
    style J fill:#90EE90
    style M fill:#87CEEB
```

---

## 💎 5. Luồng Mua Chương VIP - Paywall

```mermaid
graph TD
    A["Độc giả<br/>Bấm chương VIP"] --> B["🔒 Hiện cửa sổ<br/>Xem trước 20%<br/>Giá: 10 Hạt dẻ"]
    
    B --> C{Quyết định?}
    
    C -->|Xem trước| C1["👁️ Đọc 20%<br/>Nội dung"]
    C1 --> C2{Mua?}
    C2 -->|Yes| D
    C2 -->|No| E["⬅️ Quay lại<br/>Danh sách truyện"]
    
    C -->|Mở khóa ngay| D["Kiểm tra ví<br/>Hạt dẻ >= 10?"]
    
    D --> F{Đủ tiền?}
    
    F -->|Có| G["✓ Xác nhận<br/>Trừ 10 Hạt dẻ"]
    F -->|Không| H["⚠️ Không đủ Hạt dẻ<br/>[Nạp thêm]<br/>[Xem trước]<br/>[Hủy]"]
    
    H --> H1{Chọn?}
    H1 -->|Nạp| I["💰 Chuyển sang<br/>trang thanh toán"]
    H1 -->|Xem trước| C1
    H1 -->|Hủy| E
    
    G --> J["📖 Đọc chương<br/>đầy đủ 100%"]
    J --> K["💾 Lưu tiến độ<br/>Chọn chương tiếp"]
    
    K --> L["🎉 Check hoàn thành:<br/>Unlock achievement?<br/>Tăng điểm?"]
    
    I -.-> M["👉 Nạp Hạt dẻ xong<br/>Quay lại mua chương"]
    M -.-> G
    
    style A fill:#E8A080
    style G fill:#90EE90
    style J fill:#87CEEB
```

---

## 🎮 6. Gamification Flow - Vòng Quay May Mắn

```mermaid
graph TD
    A["Người dùng<br/>Bấm Vòng Quay"] --> B{Lần quay<br/>hôm nay?}
    
    B -->|Lần 1| C["🎁 MIỄN PHÍ<br/>Bấm quay"]
    B -->|Lần 2+| D["💰 Chi 10 Hạt dẻ<br/>để quay?"]
    
    D --> D1{Có đủ?}
    D1 -->|Không| E["⚠️ Nạp Hạt dẻ<br/>để tiếp tục"]
    D1 -->|Có| C
    
    E --> E1["[Nạp Hạt dẻ] [Hủy]"]
    
    C --> F["🎡 Vòng quay<br/>Animation"]
    
    F --> G{"Kết quả<br/>Random"}
    
    G -->|25% - 🌰 30 Hạt| H1["Cộng 30 Hạt dẻ"]
    G -->|20% - 🎫 Voucher| H2["Voucher mở<br/>1 chương VIP"]
    G -->|5% - 💎 100 Hạt| H3["Cộng 100 Hạt dẻ<br/>🎉 Hiếm!"]
    G -->|20% - 🍀 Hoàn lại| H4["Hoàn 10 Hạt<br/>dùng quay"]
    G -->|30% - ❌ Trắng| H5["Không có gì<br/>Thử lại ngày mai"]
    
    H1 --> I["✅ Thêm vào ví<br/>Thông báo popup<br/>Sound effect"]
    H2 --> I
    H3 --> I
    H4 --> I
    H5 --> I
    
    I --> J["📊 Cập nhật<br/>Daily wheel<br/>Lịch sử quay"]
    
    J --> K{Tiếp tục?}
    K -->|Quay lại| A
    K -->|Đóng| L["✅ Hoàn thành<br/>Quay mai thử lại"]
    
    style A fill:#E8A080
    style I fill:#90EE90
    style J fill:#FFD700
    style L fill:#87CEEB
```

---

## 🔗 7. Affiliate Marketing Flow - Tác Giả & Admin

```mermaid
graph TD
    A["Tác giả<br/>Quản lý Affiliate"] --> B["Chọn loại widget<br/>Banner/Text/Button"]
    
    B --> C["Chọn vị trí<br/>Đầu/Giữa/Cuối chương"]
    
    C --> D["Cấu hình<br/>Link affiliate<br/>Product/promo<br/>Commission %"]
    
    D --> E["📋 Xem trước<br/>Widget render"]
    
    E --> F{Đồng ý?}
    F -->|Sửa| C
    F -->|✅ Lưu| G["🔗 Widget live<br/>Xuất hiện trong<br/>các chương<br/>được chọn"]
    
    G --> H["📊 Theo dõi<br/>Analytics affiliate"]
    
    H --> H1["👁️ Impressions<br/>Lần hiện widget"]
    H1 --> H2["🖱️ Clicks<br/>Lần bấm"]
    H2 --> H3["💳 Conversions<br/>Lần mua"]
    H3 --> H4["💰 Commission<br/>Tiền nhận"]
    
    H4 --> I["📈 Biểu đồ<br/>CTR, Conversion rate<br/>Earnings/ngày"]
    
    I --> J["💵 Rút tiền<br/>Affiliate earnings<br/>Min: 100K VNĐ"]
    
    J --> K["✅ Được duyệt<br/>Chuyển khoản ngân hàng<br/>hoặc ví"]
    
    style A fill:#E8A080
    style G fill:#FFE4B5
    style H4 fill:#90EE90
    style K fill:#87CEEB
```

---

## 📱 8. Mobile App - Reading Experience (Optional PWA/Native)

```mermaid
graph TD
    A["📱 Mở App<br/>Hạt Dẻ Comic"] --> B{Trạng thái?}
    
    B -->|Đã login| C["🏠 Trang chủ<br/>Gợi ý, Trending"]
    B -->|Chưa login| D["🔐 Đăng nhập<br/>hoặc Đăng ký"]
    
    D --> E["✅ Login thành công"]
    E --> C
    
    C --> F["📚 Chọn truyện<br/>hoặc mở từ<br/>lịch sử"]
    
    F --> G["📖 Đọc<br/>Chế độ dọc/ngang<br/>Tuỳ chỉnh font/size"]
    
    G --> H{Gặp chương<br/>VIP?}
    
    H -->|Đủ Hạt dẻ| I["🔓 Mở khóa<br/>-10 Hạt dẻ"]
    H -->|Không đủ| J["💰 [Nạp Hạt dẻ]<br/>[Xem 20%]"]
    
    I --> K["📖 Đọc VIP<br/>Tắt quảng cáo"]
    J --> L{Chọn?}
    L -->|Nạp| M["💳 Payment<br/>Giao dịch được<br/>lưu ngoại tuyến"]
    L -->|Xem 20%| N["👁️ Preview"]
    
    M --> K
    N --> O["⬅️ Quay lại"]
    
    K --> P["✅ Đã đọc<br/>Lưu vị trí tự động"]
    P --> Q["Chương tiếp<br/>hoặc quay lại"]
    
    Q --> R{Hành động?}
    R -->|Đọc tiếp| F
    R -->|Bình luận| S["💬 Comment<br/>Upvote,tag bạn"]
    R -->|Chia sẻ| T["📤 Share<br/>Facebook, Message"]
    R -->|Profile| U["👤 Profile<br/>Ví, Tủ sách<br/>Bảng xếp hạng"]
    
    S --> V["✅ Hoàn thành<br/>+5 Hạt dẻ"]
    T --> V
    U --> V
    
    style A fill:#E8A080
    style K fill:#90EE90
    style P fill:#87CEEB
```

