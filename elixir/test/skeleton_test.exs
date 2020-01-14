defmodule SkeletonTest do
  use ExUnit.Case
  doctest Skeleton

  test "greets the world" do
    assert Skeleton.hello() == :world
  end
end
