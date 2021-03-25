<template>
  <div id="app">
    <Menu />

    <div class="body-right">
      <Header />
      <Content />
    </div>
  </div>
</template>

<script>
import Content from "./components/layout/Content.vue";
import Header from "./components/layout/Header.vue";
import Menu from "./components/layout/Menu.vue";

export default {
  name: "App",
  components: {
    Content,
    Header,
    Menu,
  },
};
</script>

<style>
 @import './assets/scss/common/main.css';
#app{
  margin: 0;
  padding: 0;
  display: flex;
}
.body-left {
  width: 220px;
  height: 100vh;
  border-right: 1px solid #bbbbbb;
  background-color: #24344b;
}

.body-right {
  height: 100vh;
  width: calc(100% - 221px);
  padding: 0 0 0 0px;
}
</style>
