﻿// See https://aka.ms/new-console-template for more information


using Template;

const string inputReal = @"#############################################################################################################################################
#.........#.........#...........#.....#.............#.........................#.........#.............#...#.#.........#...................#E#
#.#.#####.#.###.###.###.###.#.#.#.#.###.#########.#.#.###.#######.#.#########.#.#####.#.#.#####.#####.#.#.#.#.###.#.#.#.#######.#########.#.#
#.#.....#.......#.#.....#.......#.#.#...#...#.#...#.#...#.#.#...#.#.#.....#.#.#.#.....#.#.#...#.....#...#.#.....#...#.#.#.#...#.....#...#.#.#
#.#####.###.#####.#.#######.#.###.#.#.#.#.#.#.#.###.#.#.#.#.#.#.#.#.#.###.#.#.###.###.#.#.###.#####.#####.###.###.#####.#.#.#.#####.#.#.#.#.#
#.....#.....#...#...#.......#.#...#.#...#.#...#...#...#.#.#...#...#...#...#.......#.#...#.#.....#...#...#...#.#...#.......#.#.....#.#.#...#.#
#########.#.#.###.###.#####.###.###.###.#.#.#####.###.#.#.#.###########.#####.#####.#.#.#.#.###.#.###.#.###.###.#.#.#######.#####.#.###.###.#
#...........#.....#...#...#.......#...#.#.#.#...#...#...#.#...#.#.....#...#...........#.#...#.#.....................#.#...#.#.#...#...#.....#
#.#########.#.#####.###.#.#.#######.###.#.###.#.###.#.###.###.#.#.#.#.###.#.#.#.###.###.#####.#.#########.#######.###.#.#.#.#.#.#####.#####.#
#...#...#...#.....#...#.#.#...#.....#...#.#...#.....#...#...#.#...#.#.....#.#.#.#...#...#.......#...#...#.#...#...#...#.#...#.........#...#.#
###.#.#.#.#.#######.#.#.#.#.#.#.#####.#.#.#.#.#####.#.#.###.#.#####.#####.#.#.#.#.#####.#.#######.#.#.###.#.#.#.#.###.#.###############.#.#.#
#...#.#...#.....#...#.#.#...................#.#...#...#...#.#...........................#.#.....#.#.#...#.#.#...#.....#.#...............#.#.#
#.###.#########.#.#.#.#.#.#####.#.#.#.#.#.#.###.#.###.###.#.#########.#.###.#.#.###.###.#.#.#.#.#.#.#.#.#.#.#####.###.#.#.###.###########.#.#
#.#...#.....#.#.#.#...#.#.#...#...#.#...#.#.....#...#.#...#...#...#...#.....#.#.#...#...#.#.#.#...#.#.#.#.#.#.....#...#.........#...#.....#.#
#.#.###.###.#.#.#.#####.###.#.#####.#####.#########.#.#.#####.#.#.#.#########.#.###.#.#.#.###.#####.###.#.#.###.#.#.#########.#.#.#.#.#######
#.#...#...#...#.#...#.....#.#...#.......#...#.....#.....#...#...#.#.....#...........#...#.#...#...#.....#.#.....#...#.....#...#...#.#.......#
#.###.###.###.#.###.#.###.#.###.#.#####.###.#.###.#########.#####.#####.#.###########.###.#.#####.#####.#.#######.###.###.#.#######.#######.#
#...#...#.#...#.....#.....#.#.....#.........#.#...#.........#...#.......#.#.....#.....#...#.....#.#.....#...#.....#...#.#.#.........#.......#
###.###.#.#.###.#.#.#.#####.#####.#.#########.#.#######.###.###.###.###.#.#.###.#.#####.#######.#.#.#######.#.#####.###.#.#########.#.#####.#
#.........#...#.#.#.#...........#.#.....#.#...#...#.....#.#...#...#.....#.....#.....#...#.......#...#.....#...#.....#...........#.....#.....#
#.###.#####.#.#.###.#####.#####.#.#.#.#.#.#.#.###.#.#####.###.###.#.###.###.#.#####.#.###.#######.###.###.###.###.#.#.#########.#.#.###.#####
#.............#...#.........#...#.#...#.#.....#.#...#.........#...#.#.#.....#.....#.#.#...#.....#.#.#.#.#...#.....#.#...#.#...#...#...#...#.#
#.###.#.#.#.#####.#########.#.###.#####.#####.#.#.#####.#######.#.#.#.#####.#####.#.#.#.#####.#.#.#.#.#.###.#####.#.###.#.#.#.#####.#.###.#.#
#.#.#.#.#...#.....#...#.....#.#.......#.......#...#...#.........#.#.#.....#...#...#.#.#...#...#.#...#.#...#.....#.#.#.....#.............#...#
#.#.#.###.#.#.###.#.###.#####.#.#####.#.#.###.#####.#.###########.#.###.#.###.#.###.#.###.#.#####.###.#.#######.###.#######.###.#####.#.###.#
#.#.#.....#...#.#...#.....#...#.#.#.....#.#.#.#.....#.#.........#.#...#.#...#.#.#...#.....#.......#...#.....#.#.....#.......#...#...#.#...#.#
#.#.#.#####.###.###.#.#####.###.#.#.#####.#.#.#.#####.#.#########.###.#####.#.#.###########.#######.###.#.#.#.###.#.#.#######.###.#.###.###.#
#.........#.#.....#.#.#.#...#.#...#.....#.#.#.#...#...#...#.....#.#.#.#...#.#.#...#.....#...#.....#.#...#.#...#...#.#.#.....#.#...#.#...#...#
#.###.#####.#.#.###.#.#.#.###.###.#####.#.#.#.###.#.###.#.#.###.#.#.#.#.#.#.#.#.#.#.###.#.###.###.#.#####.###.###.#.#.#.###.#.#.###.#.###.###
#.#.........#.#.#...#.#.#.#...#...#.....#.#.#.#...#.#...#...#.#...#.#.#.#...#...#...#...#.....#...#.#.....#.......#.#.....#.#.#.#.....#...#.#
###.#.#########.#.###.#.#.#.###.###.#.###.#.#.#.###.###.#####.#####.#.#.#####.#.#####.###.#####.###.#.###########.#.#######.#.#.#####.#.###.#
#...#...........#.#.....#.#.......#...#...#...#...#...#.#.....#...#.#.#.......#.#...#.....#...#.#...#.#.....#...#.#...#...#.#.#.....#.#...#.#
#.#########.#####.#.#####.#####.#####.#.#####.###.###.#.###.#.#.#.#.#.#.#.#.###.###.#######.#.#.#.###.#.###.#.#.#.###.#.#.#.#.#.###.#####.#.#
#...#.....#.......#...#...#...#.#.....#.............#.#.....#...#.....#.#.....#.........#.#.#...#.#.#...#...#.#.#.#...#.#.#.#.#...#.........#
###.#.###.###########.#.###.#.###.###################.#############.#.#######.#########.#.#.#.###.#.#.###.#.###.#.#.###.#.#.#.###.#####.###.#
#...#.#.#.............#...#.#.#...............#...#...#...#.....#...#.....#.#...#.....#...#.#.............#...#...#.#.#.#...#.#.#.....#...#.#
#.###.#.#################.#.#.#.#############.#.#.#.###.#.#.###.#.#####.#.#.###.#.#######.#.#######.#######.#.#####.#.#.#####.#.#.#.###.#.#.#
#.#...#.....#...........#...#.....#.....#.......#...#...#.#.#.#.#.#...#.#.#.#...#.....#...#.#...#...#.....#.#.....#...#...#...#.....#...#.#.#
#.#.###.###.#.###############.#.#.#.###.#########.#.#.###.#.#.#.###.#.#.#.#.#.###.###.#.###.#.#.#####.###.#.#####.###.###.#.#####.###.#.#.###
#...#...#...#.........#.....#.....#.#.#.#.......#...#.#.....#.#...#.#.#.....#...#...#...#...#.#.#.......#...#...#.......#.#.#...#.....#.#...#
#.###.#.#.#######.#.#.#.###.#####.#.#.#.#.#####.###.#.#######.###.#.#.###.#.###.#########.###.#.#.#######.#.###.#########.#.#.#.#.#####.###.#
#...#.#.#.......#.#.#...#...#...#.#.#.#...#...#.#...#...#...#.....#.#.....#...#.........#.....#.#.#.......#...#.....#...#.#...#...#.....#...#
###.#.#.#####.#.#.#.#####.###.###.#.#.#####.#.#.#######.#.#.#.#####.#######.#########.#.#.#####.#.#.#########.#.###.#.#.#.#.#####.#.#.###.#.#
#...#.#...#.......#...#.....#.#...#.#.......#.#.......#.#.#.#.......#.#.................#.#...#...#.....#.....#...#.#.#...#.#...#...#.#...#.#
#.#######.#.#.#######.#.###.#.#.###.#######.#.#######.#.#.#.###.#####.#.#####.#.###.#######.#.#####.###.#.#.#######.#.#####.#.#.#.#.###.###.#
#.........#.#.#...#...#...#.#.#.....#.......#.#.....#...#.......#.....#.#.....#...#.........#.#...#.#...#.........#.#.....#.#.#...#.#...#...#
#######.###.#.#.#.#.###.###.#.#.#.###.#######.#.#.#######.###.###.###.#.#.###.###.###########.#.#.###.###########.#.#####.###.###.#.#.###.#.#
#...#.....#...#.#.#.#.#...#.#...#.#.#.....#.......#.....#.#.#.....#.#.#.#...#...#.......#...#...#.....#...#.............#.....#.............#
#.#.#.###.###.#.#.#.#.#.#.#.#####.#.#.###.#.#######.#.#.#.#.#####.#.#.#.###.###.#.###.#.#.#.#######.###.#.###.#####.###########.#.#.#####.#.#
#.............#.#.#.....#.#.#.....#...#...#...#.....#.#.#.#.#...#...#.#...#.#.......#.#.#.#.......#.#...#...#.#...#.#.....#.....#.#.#...#.#.#
#.###.#.#.###.#.#.#.#.###.#.#.#####.###.#######.#####.###.#.#.#.#####.###.###.#.#####.#.#.#.#######.#.#####.###.#.###.###.#.#####.#.#.#.###.#
#.#...#.....#...#...#...#.#.#.#...#...#.......#...#.#...#...#.#...#.....#.....#.#...#.#.....#.......#.#.........#.....#.#.#...#...#.#.#...#.#
#.#.###.#.#.#.#.#######.#.#.#.#.#####.###.###.###.#.###.###.#.###.#.#.###.#####.#.#.#.#####.#.###.#.#.#################.#.#.#.###.#.#.###.#.#
#...#...............#...#...#.#.....#...#.#...........#...#.#...#...#.#...#...#.#.#...#.....#.......#.#.....#.....#.....#.#.#.#...#.#.#.....#
#.###.#.#.#.#.###.#.#.###.#.#.###.#.###.#.#.#.#.#######.#.#.###.#####.#.###.#.#.#.#######.###.#.#####.#.###.#.#.###.###.#.###.#.#.#.#.#####.#
#.#.......#.#...#.#.#...#...#...#.#.....#.#.#.#.#.........#...#.#...#.#...#.#.#.#...#...#.#.#...#...#.....#.#.#.....#.....#...#.....#.....#.#
#.#######.#.#.#.#.#.###.#.#.###.###.#####.#.###.#.###.#######.#.#.#.#.###.#.#.#####.#.#.#.#.###.#.#.#######.#########.#.#.#.###.###.#####.###
#.#.......#...#...#.#...#.#...#...#.#.....#.....#.#...#.....#.....#.#.#...#.#.....#...#.#.....#...#...#.....#.........#.#.#.......#.....#...#
#.#.#####.#.#.#####.#.###.###.###.#.###.#.#######.#.#.#.#.###.#####.###.###.###.#.#.###.#####.#####.###.#####.#.#######.#.#####.#.#####.###.#
#.#.....#...#...#...#.#.#...#.....#.....#.#.......#.#.........#.#...#...#...#.#...#...#.#...#.......#...#.#...#.........#.............#...#.#
#.#.###.#.###.###.###.#.###.#############.#.#######.#.#######.#.#.###.###.#.#.#.#######.#.#.###.#####.###.#.#.###.#############.#.#.#####.#.#
#.#...#.....#.#...#.#...#.#.....#.......#.#.#...#.#.#.#.....#...#.......#.......#.......#.#.........#.#.....#...#.....#...#...#...#.......#.#
#.#.#.###.#.#.#.###.###.#.#####.#.#.###.#.#.#.#.#.#.#.#.#.#.###############.#.###.#.#####.###########.#.#######.#.#.###.#.#.#.#.###.#####.#.#
#.#.....#.#.#.#.#.....#...#...#...#...#.#.#...#.#...#...#.#.....#.........#.#...#.#.........#...#.....#.#.......#...#...#...#...#...#.....#.#
#.#.###.#.#.#.#.###.#.###.#.###.#####.###.#####.###.###.#.#####.#.#######.#.###.#.###########.#.#.#####.###.#.#.#####.#######.#.#.###.###.#.#
#.#...#...#.#.#...#.#...#.#.........#.....#...#...#...#.#.......#...#.......#.#.#.....#.......#.#.....#.....#.#.........#.....#...#...#.....#
#.#.#.###.#.#####.#.#.#.#.#######.#.#######.#####.#####.#####.#.###.#.#####.#.#.#####.#.#######.#####.#################.#.###.#.#####.###.#.#
#...............#.#.#.#.#.......#.#...#.....#...#.....#.#.....#.....#...#...#.#...#.#.#...#...#.....#.........#.........#...#.#.....#...#.#.#
#####.#.#.###.###.###.#.#######.#.###.#.###.#.#.#####.#.#.###.###.#.#####.#.#.###.#.#.###.#.#######.#.#######.#.#######.###.#.#.###.#.#.#.#.#
#...#.#...#...#...#...#...#.....#...#.#...#.#.#.....#...#.#.........#.....#.#.....#.....#.#.........#.#...#...#.#...#.....#.#.#.....#.#.#.#.#
#.###.###.#.#.#.###.#######.#######.#.#.#.#.#.###.#######.#.#########.#####.#.#######.###.#.#########.###.#.###.#.#.#.###.#.#.#.#####.#.#.#.#
#...#.#...#.#.#.#...........#.......#.#...#...#...#.......#...#.......#...#.#.......#.#...#.#.......#.....#.#.....#.#...#...#.#.....#.#.#.#.#
#.#.#.#.#.#.#.#.#.###########.#######.###.#####.#.#.#.#####.#.#.#########.#.#######.###.###.#.###########.#.#######.#.#.###########.###.#.#.#
#.#...#.....#.#.#.#.........#...#...#.#...#.#...#.#.#.#.....#.#.........#.#...#...#.#...#...#...........#.#.......#...#.#.........#.....#.#.#
#.#####.#.#.###.#.#########.#.#.#.#.###.#.#.#.###.#.###.###.#.#########.#.###.#.#.#.#.###.#########.#.###.#######.#####.#.###.###########.#.#
#.......#...#...#.........#...#...#.#...#...#...#.#.....#.#.#.....#...#.#.....#.#.#...#.#.#.......#.#...#...#...#...#...#.#.#...#.......#...#
#########.###.###.#.#####.#.#######.#.###.#.###.#########.#.#####.#.#.#.#########.#.###.#.#.#####.#####.###.#.#.###.#.###.#.###.#.#####.#.###
#.......#...#...#.#...#.#.#.....#...#...#.#...#...#.......#.#...#.#.#.#.#...........#...#...#...#...#.....#.#.#.#.#.#...#.....#.......#...#.#
#.###.###.#.###.###.#.#.#.#####.#.#.###.#####.###.#.#.#####.#.#.#.###.#.#.###.#.#.###.#.#####.#####.#.#.###.#.#.#.#.#.#.#####.#####.#.#####.#
#.#.#.......#.#.....#.#...#.....#.#...#.........#...#.#...#...#.#.....#...#...#...#...#...#...#.....#.#.#...#.#...#.#.#.....#...#...#.#.....#
#.#.#########.#######.#.#######.#.###.#.#######.#####.#.#.#####.#########.#.#######.###.#.#.#.#.#####.###.###.###.#.#.#####.###.#####.#.###.#
#.#.#.........#.......#.......#.#...#...#...#.#...#.#...#...#...#.....#...#.....#...#...#.....#.....#.#...#...#.#.#.#.#...#...#.....#.....#.#
#.#.#.#####.#.#.#############.#.#.#.#####.#.#.###.#.#####.#.#.###.###.#.#.###.#.#.###.#############.#.#.#####.#.#.#.#.#.###.#.#####.#######.#
#...............#.....#.......#.#.#.#.....#.#.....#.#.....#.#.#...#.#.#.....#.#.#.#.#...............#...#.....#...#.#.#.#.......#.#.........#
#.#.#.#.#######.###.#.#.#.#.#.#.#.#.#.#####.###.#.#.#.#####.#.#.###.#.#####.###.#.#.#####.###########.#####.###.###.#.#.#.#####.#.#########.#
#.#.............#...#.....#.#.#...#.....#.#...#.....#...#...#.#...#.#.......#...#.#...#.....................#.#.#.#.#...#.#.#...#...#...#...#
#.#.#.#######.#.#.#.###.#.###.#########.#.###.#####.###.#####.###.#.###.#####.#.#.#.###.###########.#########.#.#.#.#.#.#.#.#.###.#.#.###.###
#.#...#.......#.#.#.....#.....#.........#...#...#...#...#...............#.....#.#.#.....#...#.....#.#.....#.......#.#...#.#...#...#...#...#.#
#.###.#.#######.#.#####.#.#.###.###########.###.#####.###.###.###.#.###.#####.#.#.#.#.###.###.###.###.###.#.#######.#.###.#.###.#.#####.###.#
#...#...#.......#.#...#.#.......#.........#...#.....#...#...#.#...#...#.#...#.#.#...#.#.....#.#.....#.#.#.#...#.....#.#...#...#.#.....#.....#
###.#.###.#######.###.#.#.#######.#.#####.###.#####.###.###.#.#.###.#.#.#.#.#.#.###.#.#####.#.#####.#.#.#.#####.###.###.#####.#.#.###.#####.#
#.............#...#...#...#.......#.#...#.....#.....#...#...#.#...#.#.#...#...#.#...#.....#.#...#.....#.........#.#.....#.....#.#...#.......#
#.#.#.#.#####.#.#.#.#.###.#.#########.#.#.###.#.#####.###.###.###.#.#.#.#########.#######.#.###.#.#####.#########.#.#.#######.#.#.#.#########
#.......#.....#.....#.#...#.#.........#.#...#.#...#...#...#.#...#.#.#.#.#...#.........#...#.....#.#...#.#.......#...#.......#.....#.#.......#
#.#.#.#.#.###.#######.#.###.#.#########.#.#.#####.#.###.###.#.#.#.###.#.#.#.#.#######.#.###.#.#####.#.###.###.#.#.#########.#####.#.#.#####.#
#.........#.....#.....#.#.......#.....#...#.......#.#...#.......#...#.#...#...#.....#...#...#.......#.....#.....#.#.......#.........#.....#.#
#.###.#.#.#######.#####.#######.#####.#####.#####.#.#.###.#########.#.#.#.#######.#.###.#.#########.#.#####.#####.#.#.###.#######.###.###.#.#
#...#...#...#.....#.....#...#.............#.#...#...#.#...#.#.......#.#.#.#.....#.#...#...#.........#.....#.....#...#.#...#...............#.#
#.#.#.#.#.#.#.#####.#####.#.###.#########.#.#.#.#####.#.###.#.#######.#.#.###.#.#.###.#####.#######.#####.#####.#####.#.###.#.###.#.#.#.###.#
#.#.#.....#.......#.......#...#...#.....#.#.#.#.....#.#.....#...#.....#.#.....#...#.#.......#...#...#.#...#.#...#.....#...#.#.#...#...#.#...#
#.###.###.###################.#.#.#####.#.#.#.#####.#.#########.#.###.#############.#########.###.###.#.###.#.###.###.###.#.#.#.#.#####.#####
#.....#.........#...........#.#.#.......#...#.....#...#...#.....#.#...#.......................#...#.....#...#.#.#.#.#...#.#.#.#...#.....#...#
#.#####.#.#####.#.#########.#.#.###########.#####.#.###.#.#.#######.###.#.#.#############.#####.###.#####.#.#.#.#.#.#.###.###.###.#.#####.#.#
#.....#.......#...#.....#.....#.#.................#.....#...#.......#...#.#.#.......#...#.#.....#.#.#.....#.#.#.#...#...#.#...#...#...#...#.#
#####.###.###.#####.#.#.#.###.#.#.###############.#.#.#######.#####.#.###.###.###.#.#.#.###.#####.#.###.###.#.#.###.###.#.#.###.###.#.#.###.#
#...#.#.......#.......#.#.....#.#.#...#.....#.....#.#...#.#...#...#.#...#...#.#...#.........#.....#...#.#...#.#.#.....#.#.#...#...#.#.....#.#
#.#.###.#.#####.#####.#.#.#.###.#.#.#.#.###.#.#.###.###.#.#.#.#.#.#####.###.#.#.#.#############.#####.###.#.#.#.#.#####.#.###.###.#####.###.#
#.#.....#.......#...#.#.....#...#.#.#.......#.....#.#...#...#...#.#.......#.....#...#.........#.#...#.....#.#.#...#.....#.....#...#...#.#...#
#.#######.#.###.#.#.#########.#.#.#.###.###.#####.###.###.#######.#.###############.#######.#.#.#.#.#####.###.#.###.###.#######.###.#.###.#.#
#.#...........#.#.#.....#.....#...#...#.....#...#...#...#.#.....#.#.#...........#.#.........#.#.#.#.#.....#...#.#...#.#.#.....#...#.#...#.#.#
#.#.#####.#.#.#.#.#####.#.###########.#.###.#.#.###.###.#.#.#####.#.#.#########.#.###########.#.#.#.#.#####.#####.###.#.#.###.###.#.###.#.#.#
#...#.......#.#.#.#...#.#.....#...#...#...#.#.#...#...#.#...#...#...#.#.......#.#.#.....#.....#...#...#...#.#.....#.....#.#...#...#...#...#.#
#.#######.#.#.###.#.#.#.#####.#.#.#####.#.#.#.#####.#.#.#####.#.#.#.#.#.###.#.#.#.#.#.###.#############.#.#.#.#.###.#####.#.###.###.#.###.#.#
#.........#.#.#...#.#.#...#.#...#.....#.#.#...#.....#.#.......#.#.#...#...#.#.#.#...#...#.#.........#...#...#.....#...#.......#.............#
#####.###.#.#.#.###.#.###.#.#########.###.#.###.#####.#########.###.#####.#.###.#.#.###.#.#####.###.#.###########.###.###.###.###.###.#.#.###
#...#.#.....#.#.#...#...#.#.........#.....#.#...#.............#...#.#.....#...#.#.....#.#.......#.#...#.......#...#.#.........#.#.#...#.#...#
#.#.#.#.#.#.#.#.#.###.###.#.#.#####.#####.###.#####.#########.###.#.#.#######.#.#######.#########.#########.#.#.###.#######.###.#.#.###.#.###
#.#...#...#...#.#.#...#.....#.#...#.....#.#...#.........#...#...#...#.#.....#.#.#...........#...............#...#.........#...#.#...#...#...#
#.#######.#.###.#.#.###.###.###.#.#######.#.###.#######.#.#.#.#########.###.#.#.#.#####.#.#.#.#.#############.###.###.#######.#.#####.###.#.#
#.#...#...#.....#.#...#...#.....#.........#.#...#.....#...#.#.#.......#.#.....#.#...#...#.#...#.....#.........#...#...#.....#.....#.#.#...#.#
#.#.#.#.###.#####.###.###.#.#############.#.#.###.#########.###.###.#.#.#######.###.#####.#########.#.#######.###.#.#.#.#.#######.#.#.###.#.#
#...#.#.#...#.....#.....#.#...#...#.....#.#...#...........#.....#.#.#.....#...#...#.#.....#.#.....#.........#...#.#.#.#.#.#.....#...#.#.....#
#######.#.#.#.#####.#####.###.###.#.###.#########.#####.#.#######.#.#.###.#.#.###.#.#.#####.#.#.#####.#.###.###.#.#.###.#.#.###.###.#.#.#.###
#.....#.#.#...#...#...#...#...#...#...#.........#.#.....#.#.......#.#.....#.#.....#...#...#...#.....#...#...#...#.#.....#.#.#.......#.#.....#
#.###.#.#.#.#####.###.#.###.###.#.###.###.#####.###.#####.#.#####.#.#####.#.#######.#####.#.#####.#.#####.#.#.###.#######.#.#.#######.###.#.#
#...#...#.#.#.......#.#...#.#...#...#...#...#.#...#...#...#.#...#.#.....#.#.#.....#.#.....#.....#.#...#...#.#...#.......#...#...#...#.......#
#.#.#.###.#.#.###.###.###.#.###.#.#####.###.#.###.#.#.###.#.###.#.#####.###.#.###.#.#.#.###.#####.###.#.###.#.#.#######.#######.#.#.#######.#
#.#.#.#...#...#...#.....#.#.....#.#.....#.#.#.....#.#.....#...#.#.....#.....#...#.#.#.......#.....#.#...#.#.#.#.#.....................#...#.#
###.#.#.###.###.###.#####.#####.###.#####.#.###.###.#####.###.#.#.###.#######.#.#.#.#.#.###.#.#####.###.#.#.#.#.#.#.###.#.#######.#.#.#.###.#
#...#.#.....#.....#.....#.....#.#...#.....#...#.#...#.......................#.#.#.#.#.#.#...#...#.#.......#.#.#.#.#...#...#...#...#.#...#...#
#.#########.#.#####.###.#####.#.#.#####.#.###.#.#####.###.#.###.#.#.#.###.###.#.###.#.#.#.#.###.#.#.###.###.#.#.#.###.#.###.#.#.###.#####.###
#...........#.#...#...#.....#.#...#.....#.#...#.......#...#.#...#...................#...#.#.....#...#.#...#...#.#...#.......#.#.#...#...#...#
#.#######.#####.#.#####.#####.#.###.#####.#.#.#########.#.#.###.#.#.#.#.#.#.###########.#.#.#####.###.#.#.###.#.###.###.#####.#.#.###.#.###.#
#.......#.......#.....#.#...#.............................#.....#.#.#.#...#.#.............#.#.....#.....#.#...#...#.#...#.....#.#...#.#.....#
#######.#.#.#########.#.#.#.#######.#.###.#.#######.#####.#######.#.#.#####.###.#######.###.#.#####.###.#.#.###.#.#.###.#.#####.###.#.#######
#.....#.....#.....#...#...#.......#.#...#.#.......#.#.............#.#.#...#...#.....#...#...#.....#.....................#.................#.#
#####.###.###.###.#.###.###.#####.#.#.#.#.#######.###.###.#.#######.#.#.#.###.#####.###.#.#.#####.#.#.#.#.#.#.#.#######.###.#.#####.#####.#.#
#.....#...#...#.#.#.#.....#...#.#.#.#.#...#...#.............#.................#...#...#.#.#.......#.#.#...#...#.......#...#...#.......#...#.#
#.#####.#.#.###.#.#.#########.#.#.#.#.#####.#.#.#######.#####.###########.#.###.#.###.#.#.#.#######.#.#.#####.#######.#.#.#####.#######.###.#
#S......#.......#.............#.....#...................................#.......#.....#.............#...............#.........#.............#
#############################################################################################################################################";
const string inputTest = @"###############
#.......#....E#
#.#.###.#.###.#
#.....#.#...#.#
#.###.#####.#.#
#.#.#.......#.#
#.#.#####.###.#
#...........#.#
###.#.#####.#.#
#...#.....#.#.#
#.#.#.###.#.#.#
#.....#...#.#.#
#.###.#.#.#.#.#
#S..#.....#...#
###############";
const string inputTest2 = @"#################
#...#...#...#..E#
#.#.#.#.#.#.#.#.#
#.#.#.#...#...#.#
#.#.#.#.###.#.#.#
#...#.#.#.....#.#
#.#.#.#.#.#####.#
#.#...#.#.#.....#
#.#.#####.#.###.#
#.#.#.......#...#
#.#.###.#####.###
#.#.#...#.....#.#
#.#.#.#####.###.#
#.#.#.........#.#
#.#.#.#########.#
#S#.............#
#################";



void Part1(string input) {
    var grid = input.Split(Environment.NewLine).Select(l => l.ToCharArray()).ToArray();
    var end = grid.FindCell('E');
    var start = grid.FindCell('S');
    bool CanGo(int i, int j) => grid.HasCell(i, j) && grid[i][j] != '#';
    var nextWithWeight = new Func<Reindeer, IEnumerable<(Reindeer next, long weight)>>(p => {
        if( grid[p.I][p.J] == '#') {
            throw new Exception();
        }
        var res = new List<(Reindeer next, long weight)>();
       
        if( p.Direction == Grid.Direction.Up && CanGo(p.I - 1, p.J) ) {
            res.Add( ( p with { I = p.I - 1 }, 1));
        }
        if( p.Direction == Grid.Direction.Down && CanGo(p.I + 1, p.J) ) {
            res.Add( ( p with { I = p.I + 1 }, 1));
        }
        if( p.Direction == Grid.Direction.Left && CanGo(p.I, p.J - 1) ) {
            res.Add( ( p with { J = p.J - 1 }, 1));
        }
        if( p.Direction == Grid.Direction.Right && CanGo(p.I, p.J + 1) ) {
            res.Add( ( p with { J = p.J + 1 }, 1));
        }
        res.Add( ( p with { Direction = p.Direction.Turn90ClockWise() }, 1000));
        res.Add( ( p with { Direction = p.Direction.Turn90CounterClockWise() }, 1000));
        return res;
    });
   
    var res = Dijkstra.ShortestPath(nextWithWeight, new Reindeer { I = start.i, J = start.j, Direction = Grid.Direction.Right });


    var minDistanceToEnd = res.Where( r => r.node.I == end.i && r.node.J == end.j).Select( r=>r.distance).Min();
    
    
    
    Console.WriteLine( minDistanceToEnd);
}


void Part2(string input) {
    var grid = input.Split(Environment.NewLine).Select(l => l.ToCharArray()).ToArray();
    var end = grid.FindCell('E');
    var start = grid.FindCell('S');
    bool CanGo(int i, int j) => grid.HasCell(i, j) && grid[i][j] != '#';
    var nextWithWeight = new Func<Reindeer, IEnumerable<(Reindeer next, long weight)>>(p => {
        if( grid[p.I][p.J] == '#') {
            throw new Exception();
        }
        var res = new List<(Reindeer next, long weight)>();
       
        if( p.Direction == Grid.Direction.Up && CanGo(p.I - 1, p.J) ) {
            res.Add( ( p with { I = p.I - 1 }, 1));
        }
        if( p.Direction == Grid.Direction.Down && CanGo(p.I + 1, p.J) ) {
            res.Add( ( p with { I = p.I + 1 }, 1));
        }
        if( p.Direction == Grid.Direction.Left && CanGo(p.I, p.J - 1) ) {
            res.Add( ( p with { J = p.J - 1 }, 1));
        }
        if( p.Direction == Grid.Direction.Right && CanGo(p.I, p.J + 1) ) {
            res.Add( ( p with { J = p.J + 1 }, 1));
        }
        res.Add( ( p with { Direction = p.Direction.Turn90ClockWise() }, 1000));
        res.Add( ( p with { Direction = p.Direction.Turn90CounterClockWise() }, 1000));
        return res;
    });
    var reindeerStart = new Reindeer { I = start.i, J = start.j, Direction = Grid.Direction.Right };
    var res = Dijkstra.ShortestPath(nextWithWeight, reindeerStart);
    long totalDistance = res.Where(r => r.node.I == end.i && r.node.J == end.j).Select(r => r.distance).Min();

    var partOfBestPath = new HashSet<(Reindeer pos,long distanceToStart)>();
    var stack = new Stack<(Reindeer pos,long distanceToStart)>();
    var visited = new HashSet<Reindeer>();
    stack.Push((reindeerStart,0));
    while (stack.Count > 0) {
        var current = stack.Pop();
        if( !visited.Add(current.pos)) {
            continue;
        }
        if( current.pos.I == end.i && current.pos.J == end.j) {
            partOfBestPath.Add(current);
            continue;
        }
        var distancesToCurrent = Dijkstra.ShortestPath(nextWithWeight, current.pos);
        var minToEnd = distancesToCurrent.Where(r => r.node.I == end.i && r.node.J == end.j).Select(r => r.distance)
            .Min();
        if (minToEnd + current.distanceToStart == totalDistance) {
            partOfBestPath.Add(current);
            var next = nextWithWeight(current.pos).ToArray();
            foreach (var (nextReindeer, cost) in next) {
                if( current.distanceToStart + cost > totalDistance) {
                    continue;
                }
                stack.Push((nextReindeer,current.distanceToStart + cost));
            }
        }
    }

    var bestPost = partOfBestPath.Select( r => (r.pos.I, r.pos.J)).ToHashSet();
    foreach (var pos in bestPost)
    {
        grid[pos.I][pos.J] = 'O';
    }
    grid.Print();
    Console.WriteLine(bestPost.Count());
}


void Part2b(string input) {
    var grid = input.Split(Environment.NewLine).Select(l => l.ToCharArray()).ToArray();
    var end = grid.FindCell('E');
    var start = grid.FindCell('S');
    bool CanGo(int i, int j) => grid.HasCell(i, j) && grid[i][j] != '#';
    var nextWithWeight = new Func<Reindeer, IEnumerable<(Reindeer next, long weight)>>(p => {
        if( grid[p.I][p.J] == '#') {
            throw new Exception();
        }
        var res = new List<(Reindeer next, long weight)>();
       
        if( p.Direction == Grid.Direction.Up && CanGo(p.I - 1, p.J) ) {
            res.Add( ( p with { I = p.I - 1 }, 1));
        }
        if( p.Direction == Grid.Direction.Down && CanGo(p.I + 1, p.J) ) {
            res.Add( ( p with { I = p.I + 1 }, 1));
        }
        if( p.Direction == Grid.Direction.Left && CanGo(p.I, p.J - 1) ) {
            res.Add( ( p with { J = p.J - 1 }, 1));
        }
        if( p.Direction == Grid.Direction.Right && CanGo(p.I, p.J + 1) ) {
            res.Add( ( p with { J = p.J + 1 }, 1));
        }
        res.Add( ( p with { Direction = p.Direction.Turn90ClockWise() }, 1000));
        res.Add( ( p with { Direction = p.Direction.Turn90CounterClockWise() }, 1000));
        return res;
    });
    var reindeerStart = new Reindeer { I = start.i, J = start.j, Direction = Grid.Direction.Right };
    var distanceFromStart = Dijkstra.ShortestPath(nextWithWeight, reindeerStart);

    var minDistanceToEnd = distanceFromStart.Where( r => r.node.I == end.i && r.node.J == end.j).Select( r=>r.distance).Min();
    var reindeerEnd = distanceFromStart.Single( r => r.node.I == end.i && r.node.J == end.j && r.distance == minDistanceToEnd).node;
    Console.WriteLine(reindeerEnd);
    var distanceFromEnd = Dijkstra.ShortestPath(nextWithWeight, reindeerEnd with{ Direction =reindeerEnd.Direction.Turn180() });
    var minDistanceToStart = distanceFromEnd.Where( r => r.node.I == start.i && r.node.J == start.j).Select( r=>r.distance).Min();

    var distanceFromEndDict = distanceFromEnd.ToDictionary( r =>r.node, r => r.distance); 
    var bestPos = new HashSet<(int i, int j)>();
    foreach (var tuple in distanceFromStart)
    {
        var distanceToEnd = distanceFromEndDict[tuple.node with { Direction = tuple.node.Direction.Turn180()}];
        if( tuple.distance + distanceToEnd == minDistanceToEnd) {
            //grid[tuple.node.I][tuple.node.J] = 'O';
            bestPos.Add((tuple.node.I, tuple.node.J));
        }
    }
    foreach (var pos in bestPos)
    {
        grid[pos.i][pos.j] = 'O';
    }
    grid.Print();
    /*var bestPost = partOfBestPath.Select( r => (r.pos.I, r.pos.J)).ToHashSet();
    foreach (var pos in bestPost)
    {
        grid[pos.I][pos.J] = 'O';
    }
    grid.Print();*/
   Console.WriteLine(bestPos.Count());
}

Part2b(inputReal); // 546 too low

public struct Reindeer : IComparable<Reindeer>, IEquatable<Reindeer>
{
    public int I;
    public int J;
    public Grid.Direction Direction;

    public override string ToString()
    {
        return $"({I},{J},{Direction})";
    }

    public int CompareTo(Reindeer other)
    {
        var comparison = I.CompareTo(other.I);
        if (comparison != 0) return comparison;
        var jComparison = J.CompareTo(other.J);
        if (jComparison != 0) return jComparison;
        return Direction.CompareTo(other.Direction);
    }

    public bool Equals(Reindeer other)
    {
        return I == other.I && J == other.J && Direction == other.Direction;
    }

    public override bool Equals(object? obj)
    {
        return obj is Reindeer other && Equals(other);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(I, J, (int)Direction);
    }
}