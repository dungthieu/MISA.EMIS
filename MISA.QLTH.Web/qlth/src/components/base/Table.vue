<template >
    <div class="content-table">
        <table>
            <tr>
                <th class="tb-name -col-1"></th>
                <th class="tb-name -col-5">Tên khoản thu</th>
                <th class="tb-name -col-4">Nhóm khoản thu</th>
                <th class="tb-name col-3">Mức thu</th>
                <th class="tb-name -col-2">Kỳ thu</th>
                <th class="tb-name col-3">Thời điểm thu</th>
                <th class="tb-name -col-2">Áp dụng miễn giẻm </th>
                <th class="tb-name -col-2">Cho xuất hóa đơn</th>
                <th class="tb-name -col-2">Cho xuất chứng từ</th>
                <th class="tb-name -col-2">Cho phép hoàn trả</th>
                <th class="tb-name -col-2">Khoản thu bắt buộc</th>
                <th class="tb-name -col-2">Đang theo dõi</th>
                <th class="tb-name -col-2"></th>
            </tr>
        </table>
    </div>
</template>
<script>
export default {
    name:"Table"
}
</script>
<style scoped>
    @import '../../assets/scss/common/content-table.css';
</style>