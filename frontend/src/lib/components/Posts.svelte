<script lang="ts">
    import Filters from "./Filters.svelte";
    import PostComponent from "./PostComponent.svelte";
</script>


<Filters />
<section class="container">
    {#each {length: 10} as _, i}
        <PostComponent />
    {/each}
</section>


<style>
    .container {
        display: flex;
        flex-direction: column;
        align-items: center;
        gap: 2em;
    }
</style>