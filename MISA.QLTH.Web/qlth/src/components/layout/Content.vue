<template>
  <div class="Content">
    <div class="content-bar">
      <div class="content-bar-item small-name">
        <div class="item-name">Quy trình</div>
      </div>
      <div class="content-bar-item">
        <div class="item-name">Danh sách khoản thu</div>
      </div>
      <div class="content-bar-item">
        <div class="item-name">Đăng ký khoản thu</div>
      </div>
      <div class="content-bar-item">
        <div class="item-name">Danh sách miễn giảm</div>
      </div>
    </div>
    <div class="content-filter">
      <div class=" -isTracking">
        <label class="container"
          >Hiển thị khoản thu ngừng theo dõi
          <input type="checkbox" checked="checked" />
          <span class="checkmark"></span>
        </label>
      </div>
      <div class="filter -right">
        <button class="filter -f-addNew">Thêm mới</button>
        <button class="filter -f-soft">Sắp lại thứ tự</button>
        <button class="filter -f-delete"></button>
      </div>
    </div>
    <Table/>
  </div>
</template>
<script>
import Table from "../base/Table.vue"
export default {
  name: "Content",
  components :{
      Table
  }
};
</script>
<style scoped>
@import "../../assets/scss/common/content.css";
</style>