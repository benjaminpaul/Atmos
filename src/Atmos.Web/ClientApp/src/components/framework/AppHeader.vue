<template>
    <nav class="navbar navbar-dark">
        <div class="container">
            <a class="navbar-brand" href="#">{{title}}</a>
        </div>
    </nav>
</template>

<script>
    export default {
        name: "AppHeader",
        props: {
            title: String
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