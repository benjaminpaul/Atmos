<template>
    <nav class="navbar navbar-dark justify-content-between">
        <div class="container">
            <a class="navbar-brand" href="#">{{title}}</a>
            <a class="btn btn-outline-light my-2 my-sm-0" href="#">Saved mixes&nbsp;<span class="badge badge-pill badge-light">{{numberOfSavedMixes}}</span></a>
        </div>
    </nav>
</template>

<script>
    export default {
        name: "AppHeader",
        props: {
            title: String
        },
        computed: {
            numberOfSavedMixes() {
                return this.$store.state.mixes.length;
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