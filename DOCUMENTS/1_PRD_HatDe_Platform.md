# Product Requirements Document (PRD)
## Nền Tảng Web Đọc Truyện Trực Tuyến "Hạt Dẻ Comic"

**Ngày tạo:** 2026-09-02  
**Phiên bản:** 1.0  
**Trạng thái:** Draft  

---

## 📋 MỤC LỤC
1. [Tổng Quan Sản Phẩm](#tổng-quan-sản-phẩm)
2. [Đối Tượng Người Dùng](#đối-tượng-người-dùng)
3. [Định Vị Thương Hiệu & UI/UX](#định-vị-thương-hiệu--uiux)
4. [Tính Năng Chính](#tính-năng-chính)
5. [Hệ Thống Tiền Tệ Ảo (Hạt Dẻ)](#hệ-thống-tiền-tệ-ảo-hạt-dẻ)
6. [Tính Năng Gamification](#tính-năng-gamification)
7. [Yêu Cầu Kỹ Thuật](#yêu-cầu-kỹ-thuật)
8. [KPI & Metrics](#kpi--metrics)

---

## 🎯 Tổng Quan Sản Phẩm

### Mục Đích
Xây dựng một nền tảng web đọc truyện trực tuyến hiện đại, cho phép người dùng:
- Đọc truyện miễn phí và VIP với trải nghiệm tối ưu
- Kiếm và tiêu dùng tiền tệ ảo "Hạt Dẻ"
- Tương tác với cộng đồng độc giả
- Hỗ trợ tác giả thông qua donate và Affiliate marketing

### Giá Trị Cốt Lõi
- **Người dùng (Reader):** Trải nghiệm đọc mượt mà, giao diện thân thiện, cộng đồng tích cực
- **Tác giả (Creator):** Kiếm doanh thu từ VIP content, Affiliate, và donate
- **Platform:** Mô hình kinh doanh bền vững thông qua tiền tệ ảo

---

## 👥 Đối Tượng Người Dùng

### 1. **Độc Giả Cơ Bản (Reader)**
- Tuổi: 13-60
- Nhu cầu: Đọc truyện, giải trí, tương tác cộng đồng
- Hành vi: Đọc hàng ngày, tìm truyện mới, bình luận

### 2. **Độc Giả Cao Cấp (Premium Reader)**
- Tuổi: 18-45
- Nhu cầu: Truy cập VIP content, hỗ trợ tác giả yêu thích
- Hành vi: Mua Hạt dẻ, donate cho tác giả, chuyên rõ thể loại

### 3. **Tác Giả (Creator)**
- Tuổi: 18-70
- Nhu cầu: Xuất bản truyện, kiếm doanh thu, quản lý độc giả
- Hành vi: Đăng chương, cài đặt giá, theo dõi thống kê

### 4. **Quản Trị Viên (Admin)**
- Nhu cầu: Kiểm duyệt nội dung, quản lý người dùng, thống kê platform
- Hành vi: Phê duyệt truyện, xử lý vi phạm, quản lý Affiliate

---

## 🎨 Định Vị Thương Hiệu & UI/UX

### Bảng Màu
```
Màu chủ đạo (Nâu hồng):
- Màu chính: #C08552 (Nâu ấm)
- Màu phụ: #E8A080 (Nâu hồng nhạt)
- Màu accent: #A67C52 (Nâu đậm)
- Nền: #FBF8F3 (Kem nhạt)
- Text chính: #2C2C2C (Xám đậm)
```

### Hệ Thống Hình Ảnh
- **Linh vật:** Con sóc "Dẻ" - hướng dẫn, thân thiện, xuất hiện ở 404, lỗi, trang chào mừng
- **Biểu tượng tiền tệ:** Hạt dẻ (chứng chỉ ảo) 🌰
- **Style:** Flat design, icons tròn, animation nhẹ nhàng

### Trải Nghiệm Đọc (Reading Experience)
| Tính năng | Chi tiết |
|----------|---------|
| **Tùy chỉnh cỡ chữ** | 70% → 150% |
| **Tùy chỉnh font** | Serif, Sans-serif, Comic (dành cho truyện |
| **Chế độ ban đêm** | Dark mode auto theo giờ hoặc manual |
| **Lưu vị trí** | Tự động lưu chương và dòng đang đọc |
| **Xem trước chương** | Xem 20% nội dung trước khi mở khóa |
| **Điều chỉnh dòng** | Line-height, letter-spacing |

---

## 🎮 Tính Năng Chính

### A. Tính Năng Dành cho Độc Giả

#### 1. **Quản Lý Tài Khoản**
- Đăng ký/Đăng nhập (Email, Google, Facebook)
- Hồ sơ cá nhân (Avatar, Tiểu sử, Thị hiếu truyện)
- Cài đặt bảo mật (2FA, Mật khẩu)
- Quản lý địa chỉ thanh toán

#### 2. **Tủ Sách Cá Nhân (Library)**
- Danh sách theo dõi (Watching)
- Danh sách đã đọc (Completed)
- Danh sách dự định (Wishlist)
- Ghi chú cá nhân per truyện

#### 3. **Mở Khóa Chương (Paywall)**
```
┌─────────────────────────┐
│  Truyện VIP             │
├─────────────────────────┤
│ Chương 1: Miễn phí      │
│ Chương 2-5: Miễn phí    │
│ Chương 6+: Cần mở khóa  │
│                         │
│ Giá: 10 Hạt Dẻ/chương  │
│ [Mở khóa] [Xem trước]   │
└─────────────────────────┘
```

#### 4. **Nhập Giftcode**
- Tính năng: Nhập code -> Nhận Hạt dẻ hoặc mở khóa chapter
- Tác dụng: Quảng bá, phần thưởng độc giả, sự kiện

#### 5. **Ví Hạt Dẻ & Lịch Sử Giao Dịch**
- Số dư hiện tại, lịch sử nạp, lịch sử tiêu dùng
- Xuất báo cáo giao dịch (CSV)

#### 6. **Tương Tác Xã Hội**
- **Bình luận:** Bình luận theo chương, trả lời, upvote
- **Đánh giá sao:** 1-5 sao kèm nhận xét
- **Tặng Hạt dẻ (Donate):** Tặng thẳng cho tác giả, hiển thị top donor
- **Theo dõi tác giả:** Nhận thông báo chương mới

---

### B. Tính Năng Dành cho Tác Giả

#### 1. **Quản Lý Nội Dung**
```
Trình soạn thảo WYSIWYG:
├── Text formatting (B, I, U, ...)
├── Chèn hình ảnh
├── Chèn link (ngoài/affiliate)
├── Lưu bản nháp
├── Preview trước khi đăng
└── Lập lịch đăng chương
```

#### 2. **Cài Đặt Chương VIP**
- Toggle: Chương miễn phí ↔ VIP
- Giá VIP: Tuỳ chỉnh từ 5-100 Hạt dẻ
- Hiển thị: Số người đã mua, doanh thu

#### 3. **Quản Lý Giftcode**
```
Tạo Code Hàng Loạt:
├── Số lượng: 100
├── Phần thưởng: 50 Hạt dẻ
├── Thời hạn: 30 ngày
├── Một lần dùng / Nhiều lần
└── [Tạo & Tải về]
```

#### 4. **Dashboard Tác Giả**
- Lượt xem/ngày, lượt mở khóa, doanh thu
- Top chapter, top reader
- Biểu đồ theo dõi theo thời gian

#### 5. **Tích Hợp Affiliate Marketing**
```
Widget Affiliate:
├── Banner (300x100, 300x250, 728x90)
├── Text link
├── Button bấm
├── Đầu chương / Cuối chương / Giữa nội dung
└── Theo dõi CTR & Commission
```

---

### C. Tính Năng Dành cho Admin

#### 1. **Quản Lý Người Dùng**
- Tìm kiếm, lọc, khóa tài khoản
- Xem lịch sử hoạt động
- Gửi thông báo hàng loạt

#### 2. **Quản Lý Nội Dung**
- Phê duyệt truyện mới
- Kiểm duyệt bình luận
- Xóa/khóa content vi phạm

#### 3. **Quản Lý Hạt Dẻ**
- Nạp Hạt dẻ cho người dùng (support)
- Tạo code phát hành hàng loạt
- Thống kê nạp/tiêu dùng

#### 4. **Dashboard Admin**
- Tổng DAU, MAU, retention rate
- Doanh thu (payment + Affiliate)
- Top truyện, top tác giả
- Báo cáo chậm/nhanh

---

## 💰 Hệ Thống Tiền Tệ Ảo (Hạt Dẻ)

### Luồng Kiếm Hạt Dẻ

| Nguồn | Chi tiết | Số lượng |
|-------|---------|---------|
| **Đăng nhập** | Check-in hàng ngày | 5-20 Hạt dẻ |
| **Referral** | Giới thiệu bạn (người mời + người được mời) | 50 + 50 |
| **Nhiệm vụ hàng ngày** | Đọc 30 phút, viết bình luận | 10-20 |
| **Mua trực tiếp** | Nạp tiền (VNĐ, USD) | Tuỳ gói |
| **Donate nhận lại** | Donate cho tác giả, nhận x% lại | Tuỳ chính sách |
| **Sự kiện/Seasonal** | Lễ Tết, sinh nhật | Tuỳ sự kiện |

### Gói Nạp Hạt Dẻ

| Gói | Hạt Dẻ | Giá VNĐ | Bonus | Tỉ giá |
|-----|--------|---------|--------|--------|
| Starter | 100 | 29,000 | 0 | 3.45 VNĐ/dẻ |
| Basic | 500 | 129,000 | 50 | 2.58 VNĐ/dẻ |
| Pro | 1,000 | 229,000 | 150 | 2.29 VNĐ/dẻ |
| VIP | 2,500 | 499,000 | 500 | 1.996 VNĐ/dẻ |
| Elite | 5,000 | 899,000 | 1,500 | 1.80 VNĐ/dẻ |

### Luồng Tiêu Dùng Hạt Dẻ

| Mục | Chi tiết | Giá |
|-----|---------|-----|
| **Mở khóa chương VIP** | Per chương | 5-50 Hạt dẻ |
| **Donate tác giả** | Tối thiểu 1 Hạt dẻ | Tuỳ ý |
| **Premium features** | Ad-free, priority support | 99 Hạt dẻ/tháng |
| **Vòng quay may mắn** | Cơ hội trúng Hạt dẻ/voucher | 10 Hạt dẻ/lần |

### Chính Sách Hoàn Tiền
- Hoàn 30% nếu mở khóa sai chương
- Hoàn 100% nếu đọc < 10% nội dung
- Giữ lại 80% nếu hoàn đầy đủ

---

## 🎯 Tính Năng Gamification

### 1. **Hệ Thống Điểm & Bảng Xếp Hạng**
```
Điểm thành tích (Achievement Points):
├── Đọc 1 truyện đến hết: 10 điểm
├── Để lại 10 bình luận: 5 điểm
├── Tặng Hạt dẻ đầu tiên: 20 điểm
├── Đạt 30 ngày check-in: 50 điểm
└── [Bảng xếp hạng toàn platform hàng tháng]
```

### 2. **Vòng Quay May Mắn (Daily Wheel)**
- **Quy tắc:** 1 lần quay/ngày, miễn phí lần đầu, 10 Hạt dẻ từ lần 2+
- **Phần thưởng:**
  - 🌰 30 Hạt dẻ (25%)
  - 🎫 Voucher mở 1 chương (20%)
  - 💎 100 Hạt dẻ (5% - Hiếm)
  - 🍀 Tặng lại 10 Hạt dẻ (20%)
  - ❌ Không trúng (30%)

### 3. **Nhiệm Vụ Hàng Ngày & Tuần**
```
Hàng ngày:
├── Đăng nhập: 5 Hạt dẻ
├── Đọc 30 phút: 10 Hạt dẻ
├── Bình luận 1 chương: 5 Hạt dẻ
└── Hoàn thành 3 nhiệm vụ: Bonus 20 Hạt dẻ

Hàng tuần:
├── Đọc 3 truyện khác nhau: 50 Hạt dẻ
├── 20 bình luận: 30 Hạt dẻ
└── Tặng Hạt dẻ 5 lần: 100 Hạt dẻ
```

### 4. **Huy Hiệu & Thành Tích**
| Huy Hiệu | Điều kiện | Thưởng |
|---------|----------|--------|
| 🎯 Người đọc đam mê | Đọc 100 chương | Badge + 50 Hạt dẻ |
| 💬 Bình luận tích cực | 100 bình luận được like | Badge + 30 Hạt dẻ |
| 💝 Nhà tài trợ | Donate 1,000 Hạt dẻ | Badge + Featured |
| 📚 Bộ sưu tập | Theo dõi 50 truyện | Badge + 40 Hạt dẻ |

### 5. **Tấn Công Quán/Event Hàng Tháng**
- Đọc 1 truyện = Điểm quán
- Tính điểm team → Phân phối thưởng
- Prize pool: Hạt dẻ, Premium access, Merchandise

---

## 🔧 Yêu Cầu Kỹ Thuật

### Hiệu Suất (Performance)
- **First Contentful Paint (FCP):** < 1.5s
- **Largest Contentful Paint (LCP):** < 2.5s
- **Cumulative Layout Shift (CLS):** < 0.1
- **Time to Interactive (TTI):** < 3.5s
- **Lighthouse Score:** > 90

### Bảo Mật (Security)
- HTTPS/TLS 1.3+
- CSRF token, XSS prevention
- SQL Injection protection (Parameterized queries)
- Rate limiting & DDoS protection
- 2FA cho tài khoản cao cấp
- PCI DSS compliance cho payment

### Khả Năng Mở Rộng (Scalability)
- Hỗ trợ tối thiểu 10K concurrent users
- Database sharding ready
- CDN cho assets tĩnh
- Caching strategy (Redis/Memcached)
- Message queue cho tác vụ nền

### Tương Thích (Compatibility)
- Desktop: Chrome, Firefox, Safari, Edge (latest 2 versions)
- Mobile: iOS 12+, Android 8+
- Responsive design (320px - 2560px)
- PWA ready (offline reading)

---

## 📊 KPI & Metrics

### User Metrics
| Metric | Target | Trạng thái |
|--------|--------|-----------|
| DAU (Daily Active Users) | 50,000 | - |
| MAU (Monthly Active Users) | 300,000 | - |
| Retention Day 7 | > 45% | - |
| Retention Day 30 | > 25% | - |
| Churn Rate | < 5%/tháng | - |

### Engagement Metrics
| Metric | Target |
|--------|--------|
| Avg. Session Duration | > 25 phút |
| Pages per Session | > 8 |
| Comment Rate | > 10% |
| Donate Rate | > 5% DAU |

### Business Metrics
| Metric | Target |
|--------|--------|
| ARPU (Avg Revenue Per User) | 50K VNĐ/tháng |
| Conversion Rate (Freemium → Paid) | > 8% |
| Refund Rate | < 3% |
| LTV:CAC Ratio | > 3:1 |

---

## 📅 Roadmap Phát Triển

### Phase 1: MVP (3 tháng)
- ✅ Auth & User Management
- ✅ Reader features (Read, Library, Comments)
- ✅ Basic payment (Hạt dẻ coins)
- ✅ Creator basic features

### Phase 2: Enhancement (3 tháng)
- Gamification (Achievements, Daily wheel)
- Advanced payment options
- Affiliate system v1
- Mobile app (React Native)

### Phase 3: Scale (3 tháng)
- Analytics & Admin dashboard
- AI recommendation engine
- Social features (Following, Messaging)
- International expansion

---

## ✅ Tiêu Chí Thành Công

- ✓ Launch trong 6 tháng
- ✓ Đạt 50K MAU sau 1 năm
- ✓ Positive unit economics (ARPU > CAC)
- ✓ NPS > 50
- ✓ Uptime > 99.9%

