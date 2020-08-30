<template>
    <nav class="navbar navbar-dark justify-content-between">
        <div class="container">
            <a class="navbar-brand" href="#">{{title}}</a>
            <a class="btn btn-outline-light my-2 my-sm-0" href="#" @click="toggleLoadSave">Load / Save</a>
        </div>
    </nav>
</template>

<script>
    export default {
        name: "AppHeader",
        props: {
            title: String
        },
        data() {
            return {
                showPanel: false
            }
        },
        methods: {
            toggleLoadSave() {
                this.$store.dispatch('showMixPanel', !this.showPanel);
                this.showPanel = !this.showPanel;
            }
        }
    }
</script>

<style scoped>
.navbar-brand {
    font-weight: bold;
}
    .navbar {
        box-shadow: rgba(0, 0, 0, 0.1) 0px 1px 2px;
    }
</style>