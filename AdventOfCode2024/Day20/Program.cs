﻿// See https://aka.ms/new-console-template for more information


using Template;

const string inputReal = @"#############################################################################################################################################
#...#...#...........#...#...#...#...#.....#...###...#...###.........#...#...#.......#...#...#...#...#...#...###...#...###...#...###.........#
#.#.#.#.#.#########.#.#.#.#.#.#.#.#.#.###.#.#.###.#.#.#.###.#######.#.#.#.#.#.#####.#.#.#.#.#.#.#.#.#.#.#.#.###.#.#.#.###.#.#.#.###.#######.#
#.#...#.#...#.....#...#...#...#.#.#.#...#...#...#.#...#...#.......#...#...#.#.....#.#.#...#.#.#.#.#.#.#...#.#...#.#.#.....#.#.#.#...#...#...#
#.#####.###.#.###.#############.#.#.###.#######.#.#######.#######.#########.#####.#.#.#####.#.#.#.#.#.#####.#.###.#.#######.#.#.#.###.#.#.###
#.#.....###...###.......#.......#.#.....#.......#.......#...#.....#...#.....#...#.#.#.....#...#.#.#.#.#.....#.#...#.#.......#.#.#.#...#...###
#.#.###################.#.#######.#######.#############.###.#.#####.#.#.#####.#.#.#.#####.#####.#.#.#.#.#####.#.###.#.#######.#.#.#.#########
#.#.#...###...#...#.....#.......#.......#.###...#...###...#.#...#...#...###...#.#.#...###.....#...#...#.....#.#.###.#.#...#...#...#.........#
#.#.#.#.###.#.#.#.#.###########.#######.#.###.#.#.#.#####.#.###.#.#########.###.#.###.#######.#############.#.#.###.#.#.#.#.###############.#
#.#.#.#.#...#.#.#.#.....#.......###...#.#.#...#.#.#.#.....#.###.#.#...#...#...#.#.#...#...#...#.........#...#.#.....#.#.#.#...#.............#
#.#.#.#.#.###.#.#.#####.#.#########.#.#.#.#.###.#.#.#.#####.###.#.#.#.#.#.###.#.#.#.###.#.#.###.#######.#.###.#######.#.#.###.#.#############
#.#.#.#.#...#.#.#.#.....#...#...#...#...#.#...#.#.#...#...#.....#.#.#...#.....#.#.#.#...#...#...###...#...###.#.......#.#...#.#.......#.....#
#.#.#.#.###.#.#.#.#.#######.#.#.#.#######.###.#.#.#####.#.#######.#.###########.#.#.#.#######.#####.#.#######.#.#######.###.#.#######.#.###.#
#.#...#.....#...#.#...#.....#.#.#...#.....#...#.#.......#...#...#...#...........#.#.#...#.....#...#.#...#...#.#.###...#...#.#.#.......#.#...#
#.###############.###.#.#####.#.###.#.#####.###.###########.#.#.#####.###########.#.###.#.#####.#.#.###.#.#.#.#.###.#.###.#.#.#.#######.#.###
#...#...#...#...#...#.#.###...#...#.#...#...#...#...###...#...#...#...#.....#...#.#.#...#...###.#.#.#...#.#.#.#.#...#.....#.#.#.......#.#...#
###.#.#.#.#.#.#.###.#.#.###.#####.#.###.#.###.###.#.###.#.#######.#.###.###.#.#.#.#.#.#####.###.#.#.#.###.#.#.#.#.#########.#.#######.#.###.#
###...#...#...#...#...#...#...#...#.#...#...#...#.#...#.#.......#.#...#...#...#...#.#.....#...#.#...#...#.#...#.#...#.....#.#.#.......#.#...#
#################.#######.###.#.###.#.#####.###.#.###.#.#######.#.###.###.#########.#####.###.#.#######.#.#####.###.#.###.#.#.#.#######.#.###
#.......###...###...#...#.....#.....#...###.#...#.#...#.......#.#...#.#...#...#.....#.....#...#.#.......#.#...#.....#...#...#.#...#...#.#...#
#.#####.###.#.#####.#.#.###############.###.#.###.#.#########.#.###.#.#.###.#.#.#####.#####.###.#.#######.#.#.#########.#####.###.#.#.#.###.#
#.#.....#...#.#...#...#...#.........#...#...#...#.#.#...#...#.#.#...#...#...#.#.#...#.....#.....#.......#...#.....#.....#.....#...#.#.#.#...#
#.#.#####.###.#.#.#######.#.#######.#.###.#####.#.#.#.#.#.#.#.#.#.#######.###.#.#.#.#####.#############.#########.#.#####.#####.###.#.#.#.###
#.#.#...#...#.#.#.#...#...#.###...#.#.#...#.....#.#.#.#.#.#...#.#.#.......###...#.#.#.....#.............#...#.....#.#.....#...#...#.#...#...#
#.#.#.#.###.#.#.#.#.#.#.###.###.#.#.#.#.###.#####.#.#.#.#.#####.#.#.#############.#.#.#####.#############.#.#.#####.#.#####.#.###.#.#######.#
#.#...#...#.#.#.#.#.#.#.....#...#.#.#...#...#...#.#...#.#.....#.#.#.......###...#.#.#.....#.......###...#.#.#.....#...#...#.#.#...#.#...#...#
#.#######.#.#.#.#.#.#.#######.###.#.#####.###.#.#.#####.#####.#.#.#######.###.#.#.#.#####.#######.###.#.#.#.#####.#####.#.#.#.#.###.#.#.#.###
#.......#...#...#.#.#.#...###...#.#.....#...#.#...#.....#.....#.#.#.......#...#...#.#.....#.......#...#.#.#.#...#.#.....#...#...###.#.#...###
#######.#########.#.#.#.#.#####.#.#####.###.#.#####.#####.#####.#.#.#######.#######.#.#####.#######.###.#.#.#.#.#.#.###############.#.#######
###...#.........#.#.#.#.#.#...#.#.#...#.#...#...#...###...#...#.#.#...#...#.....#...#.....#.........#...#.#.#.#.#.#.......#...#.....#.......#
###.#.#########.#.#.#.#.#.#.#.#.#.#.#.#.#.#####.#.#####.###.#.#.#.###.#.#.#####.#.#######.###########.###.#.#.#.#.#######.#.#.#.###########.#
#...#.....#...#.#.#.#...#...#.#.#.#.#.#.#.#.....#.....#.....#.#.#.#...#.#...#...#.#.....#.#...........#...#.#.#.#.#.......#.#...#...#...#...#
#.#######.#.#.#.#.#.#########.#.#.#.#.#.#.#.#########.#######.#.#.#.###.###.#.###.#.###.#.#.###########.###.#.#.#.#.#######.#####.#.#.#.#.###
#.....#...#.#...#.#.......#...#.#.#.#.#.#.#...#.......#...###.#.#.#.###.#...#...#.#...#.#.#.#...#...###.#...#.#.#.#.....###.#.....#...#...###
#####.#.###.#####.#######.#.###.#.#.#.#.#.###.#.#######.#.###.#.#.#.###.#.#####.#.###.#.#.#.#.#.#.#.###.#.###.#.#.#####.###.#.###############
#.....#...#.....#.#.......#.....#.#.#...#...#.#.#.....#.#.#...#.#.#.#...#...#...#...#.#.#.#.#.#.#.#.#...#...#.#...#.....#...#.......#.......#
#.#######.#####.#.#.#############.#.#######.#.#.#.###.#.#.#.###.#.#.#.#####.#.#####.#.#.#.#.#.#.#.#.#.#####.#.#####.#####.#########.#.#####.#
#...#...#.......#.#.....#.......#.#.....#...#.#.#.#...#.#.#.###.#.#.#...###.#...#...#.#...#.#.#.#.#.#.#.....#.#...#.......#.........#.#.....#
###.#.#.#########.#####.#.#####.#.#####.#.###.#.#.#.###.#.#.###.#.#.###.###.###.#.###.#####.#.#.#.#.#.#.#####.#.#.#########.#########.#.#####
#...#.#...#.....#.#...#...#...#.#.......#...#.#.#.#.#...#.#...#.#.#...#.#...#...#...#.....#...#.#.#...#...###.#.#...........#...#...#.#.#...#
#.###.###.#.###.#.#.#.#####.#.#.###########.#.#.#.#.#.###.###.#.#.###.#.#.###.#####.#####.#####.#.#######.###.#.#############.#.#.#.#.#.#.#.#
#.....###...#...#...#...#...#...#.....#...#.#.#.#.#.#.###.#...#.#...#.#.#...#.....#...#...#.....#...#...#.....#.......#.......#...#...#.#.#.#
#############.#########.#.#######.###.#.#.#.#.#.#.#.#.###.#.###.###.#.#.###.#####.###.#.###.#######.#.#.#############.#.###############.#.#.#
#...#...#...#...#.....#.#.........#...#.#.#...#...#.#.#...#.###.#...#...###...#...###...###.........#.#.#.............#.#...............#.#.#
#.#.#.#.#.#.###.#.###.#.###########.###.#.#########.#.#.###.###.#.###########.#.#####################.#.#.#############.#.###############.#.#
#.#...#...#.....#.#...#.###...#...#.....#.........#.#.#...#.#...#.....#.......#.###...#...#...........#...#.............#...............#.#.#
#.###############.#.###.###.#.#.#.###############.#.#.###.#.#.#######.#.#######.###.#.#.#.#.###############.###########################.#.#.#
#...#...#...#.....#...#.....#...#.........#...#...#...#...#.#.#...#...#...#...#...#.#...#.#.#.........#.....#.........................#...#.#
###.#.#.#.#.#.#######.###################.#.#.#.#######.###.#.#.#.#.#####.#.#.###.#.#####.#.#.#######.#.#####.#######################.#####.#
###...#...#.#.###...#...#.....#.....#...#.#.#.#...#.....#...#.#.#.#.#.....#.#...#...#...#.#...#.......#.#.....###...........#...#...#.......#
###########.#.###.#.###.#.###.#.###.#.#.#.#.#.###.#.#####.###.#.#.#.#.#####.###.#####.#.#.#####.#######.#.#######.#########.#.#.#.#.#########
#...#.......#.#...#.....#.#...#.#...#.#.#...#.....#...#...###...#.#.#.....#.#...#...#.#.#.....#.....#...#.........#...#...#...#...#...#...###
#.#.#.#######.#.#########.#.###.#.###.#.#############.#.#########.#.#####.#.#.###.#.#.#.#####.#####.#.#############.#.#.#.###########.#.#.###
#.#.#.........#...#...#...#.....#.....#.............#.#.....#.....#.#.....#.#.#...#.#.#.#.....###...#.#.......#...#.#...#.....#.....#...#...#
#.#.#############.#.#.#.###########################.#.#####.#.#####.#.#####.#.#.###.#.#.#.#######.###.#.#####.#.#.#.#########.#.###.#######.#
#.#.#...#...#...#...#...#...........................#...#...#...#...#.#...#.#.#...#.#.#...#.....#.....#.....#...#.#.........#.#...#.#.....#.#
#.#.#.#.#.#.#.#.#########.#############################.#.#####.#.###.#.#.#.#.###.#.#.#####.###.###########.#####.#########.#.###.#.#.###.#.#
#.#.#.#.#.#.#.#...#.......#...#.......................#...#.....#...#.#.#.#.#.#...#...#...#...#.#...#...#...###...#.....#...#.....#...###.#.#
#.#.#.#.#.#.#.###.#.#######.#.#.#####################.#####.#######.#.#.#.#.#.#.#######.#.###.#.#.#.#.#.#.#####.###.###.#.###############.#.#
#.#.#.#.#.#.#...#.#.........#...#.....................#...#...#.....#...#...#.#.....#...#.#...#.#.#...#...#...#.....###.#.......###.....#.#.#
#.#.#.#.#.#.###.#.###############.#####################.#.###.#.#############.#####.#.###.#.###.#.#########.#.#########.#######.###.###.#.#.#
#.#.#.#.#.#.###.#.#...#...###...#...............###...#.#...#...###...........#.....#...#.#...#...#...#.....#.........#.#.....#.....#...#.#.#
#.#.#.#.#.#.###.#.#.#.#.#.###.#.###############.###.#.#.###.#######.###########.#######.#.###.#####.#.#.#############.#.#.###.#######.###.#.#
#.#.#.#.#.#.#...#...#...#.....#.......#.......#...#.#.#...#.......#.#...#.....#.###.....#.....#.....#.#.#.............#...###.#...#...###...#
#.#.#.#.#.#.#.#######################.#.#####.###.#.#.###.#######.#.#.#.#.###.#.###.###########.#####.#.#.###################.#.#.#.#########
#.#...#...#.#.............#.....#...#...#...#...#...#.....#.......#...#...#...#...#...#.........#...#...#.........###...#...#...#.#.........#
#.#########.#############.#.###.#.#.#####.#.###.###########.###############.#####.###.#.#########.#.#############.###.#.#.#.#####.#########.#
#.......#...#...#.........#.###...#.#.....#...#...........#.......#.......#...#...###.#.#...#...#.#...###...#...#.....#...#...#...#.......#.#
#######.#.###.#.#.#########.#######.#.#######.###########.#######.#.#####.###.#.#####.#.#.#.#.#.#.###.###.#.#.#.#############.#.###.#####.#.#
#.......#...#.#.#.......#...#.......#.#.......###...#...#...#.....#.....#.#...#...#...#.#.#...#.#.#...#...#...#...#...#.......#...#.....#...#
#.#########.#.#.#######.#.###.#######.#.#########.#.#.#.###.#.#########.#.#.#####.#.###.#.#####.#.#.###.#########.#.#.#.#########.#####.#####
#.......#...#.#.#.....#.#.###.........#.......#...#.#.#.###...#...#.....#.#.....#.#...#.#.....#...#.###...#...###.#.#...#.......#.......#...#
#######.#.###.#.#.###.#.#.###################.#.###.#.#.#######.#.#.#####.#####.#.###.#.#####.#####.#####.#.#.###.#.#####.#####.#########.#.#
###.....#.....#...#...#...#...#...#...........#.#...#.#...#...#.#.#.#.....#.....#.###...###...#...#.....#...#...#...#...#.....#.#...#...#.#.#
###.###############.#######.#.#.#.#.###########.#.###.###.#.#.#.#.#.#.#####.#####.#########.###.#.#####.#######.#####.#.#####.#.#.#.#.#.#.#.#
#...#...#...#....S#.....###.#.#.#.#.....#...###.#.#...#...#.#.#.#...#.....#.#...#.#.........#...#.#...#.........#...#.#...#...#...#...#...#.#
#.###.#.#.#.#.#########.###.#.#.#.#####.#.#.###.#.#.###.###.#.#.#########.#.#.#.#.#.#########.###.#.#.###########.#.#.###.#.###############.#
#...#.#...#...#########.....#...#.....#...#.....#...#...###.#.#.....#.....#.#.#.#.#.........#.#...#.#.............#.#...#...#...#.....#...#.#
###.#.###############################.###############.#####.#.#####.#.#####.#.#.#.#########.#.#.###.###############.###.#####.#.#.###.#.#.#.#
#...#...#############################.#...#...#.....#.....#.#.#...#.#...###...#...#.....#...#.#...#.#...............#...#.....#.#...#...#...#
#.#####.#############################.#.#.#.#.#.###.#####.#.#.#.#.#.###.###########.###.#.###.###.#.#.###############.###.#####.###.#########
#.....#.#############################...#.#.#.#.#...#.....#.#.#.#.#...#...###...###.#...#...#.#...#.#.#.............#...#.....#.....#...#...#
#####.#.#################################.#.#.#.#.###.#####.#.#.#.###.###.###.#.###.#.#####.#.#.###.#.#.###########.###.#####.#######.#.#.#.#
#.....#.#########################...#...#...#...#.....#...#.#...#.###...#.#...#...#.#.#...#...#.....#...#...#.....#.....#.....###...#.#.#.#.#
#.#####.#########################.#.#.#.###############.#.#.#####.#####.#.#.#####.#.#.#.#.###############.#.#.###.#######.#######.#.#.#.#.#.#
#...#...###############.......#...#...#.....#.....###...#...#.....#...#.#.#.#.....#.#.#.#.###.........#...#...###...#...#.........#...#...#.#
###.#.#################.#####.#.###########.#.###.###.#######.#####.#.#.#.#.#.#####.#.#.#.###.#######.#.###########.#.#.###################.#
#...#.###############...#.....#.#...........#...#...#.....#...###...#...#.#.#.#...#.#.#.#...#.......#.#.........###...#...#.....#.....#.....#
#.###.###############.###.#####.#.#############.###.#####.#.#####.#######.#.#.#.#.#.#.#.###.#######.#.#########.#########.#.###.#.###.#.#####
#.....#########...#...#...#...#.#.......#...#...#...###...#.....#...#...#...#.#.#.#.#.#...#.###.....#...........#...#.....#...#.#...#.#.....#
###############.#.#.###.###.#.#.#######.#.#.#.###.#####.#######.###.#.#.#####.#.#.#.#.###.#.###.#################.#.#.#######.#.###.#.#####.#
#...#...#######.#.#.#...#...#...#.......#.#.#...#.....#...#.....###...#.....#.#.#...#.....#...#.....#.....#...#...#.#...#...#.#.#...#...#...#
#.#.#.#.#######.#.#.#.###.#######.#######.#.###.#####.###.#.###############.#.#.#############.#####.#.###.#.#.#.###.###.#.#.#.#.#.#####.#.###
#.#...#E###.....#...#.....#...###...###...#...#.#.....#...#.#...###.........#...#.........#...#.....#.#...#.#.#...#...#...#...#...#...#...###
#.#########.###############.#.#####.###.#####.#.#.#####.###.#.#.###.#############.#######.#.###.#####.#.###.#.###.###.#############.#.#######
#.....#...#.#.............#.#.#...#.....#...#.#.#.....#...#.#.#...#.............#...#...#...###.......#.....#...#.#...#...#...#...#.#.......#
#####.#.#.#.#.###########.#.#.#.#.#######.#.#.#.#####.###.#.#.###.#############.###.#.#.#######################.#.#.###.#.#.#.#.#.#.#######.#
#...#...#...#.......#...#...#...#.........#...#...#...#...#...#...#.....#...#...#...#.#.......#.....#...#.....#...#.....#...#...#...#.......#
#.#.###############.#.#.#########################.#.###.#######.###.###.#.#.#.###.###.#######.#.###.#.#.#.###.#######################.#######
#.#...#...........#...#...#.....#...#...#...#...#.#.###.#.......#...#...#.#.#...#.###.#.......#...#.#.#.#.###...#.......#.....#.......###...#
#.###.#.#########.#######.#.###.#.#.#.#.#.#.#.#.#.#.###.#.#######.###.###.#.###.#.###.#.#########.#.#.#.#.#####.#.#####.#.###.#.#########.#.#
#...#.#.........#.#...###...###...#...#.#.#.#.#.#.#.#...#.#...###...#.#...#...#.#.....#...#...#...#.#.#.#.....#.#...###.#.#...#.#...#...#.#.#
###.#.#########.#.#.#.#################.#.#.#.#.#.#.#.###.#.#.#####.#.#.#####.#.#########.#.#.#.###.#.#.#####.#.###.###.#.#.###.#.#.#.#.#.#.#
###.#.###...#...#...#...................#.#.#.#.#.#.#.#...#.#.#...#.#.#.....#.#...#.......#.#.#...#.#.#.#.....#...#.#...#.#.....#.#...#...#.#
###.#.###.#.#.###########################.#.#.#.#.#.#.#.###.#.#.#.#.#.#####.#.###.#.#######.#.###.#.#.#.#.#######.#.#.###.#######.#########.#
#...#.#...#...#.....#.......#.........#...#.#.#.#.#.#.#...#.#.#.#.#.#...#...#.#...#...#...#.#.#...#.#.#.#...#...#...#...#.........#...#...#.#
#.###.#.#######.###.#.#####.#.#######.#.###.#.#.#.#.#.###.#.#.#.#.#.###.#.###.#.#####.#.#.#.#.#.###.#.#.###.#.#.#######.###########.#.#.#.#.#
#...#...#.......###...###...#...#.....#...#.#.#.#.#.#.#...#.#.#.#.#...#.#...#.#...#...#.#...#.#...#...#...#...#...#...#.#...........#...#.#.#
###.#####.###############.#####.#.#######.#.#.#.#.#.#.#.###.#.#.#.###.#.###.#.###.#.###.#####.###.#######.#######.#.#.#.#.###############.#.#
###...#...#...#...###...#.#.....#.....#...#.#.#.#.#.#.#.#...#.#.#.#...#.#...#...#.#...#...###.#...#...###...#...#...#.#.#...............#.#.#
#####.#.###.#.#.#.###.#.#.#.#########.#.###.#.#.#.#.#.#.#.###.#.#.#.###.#.#####.#.###.###.###.#.###.#.#####.#.#.#####.#.###############.#.#.#
#...#...#...#...#.....#...#.#.........#...#.#.#.#.#...#.#.#...#.#.#...#...#...#...#...#...#...#.#...#.#...#.#.#.#.....#...#...#.....#...#...#
#.#.#####.#################.#.###########.#.#.#.#.#####.#.#.###.#.###.#####.#.#####.###.###.###.#.###.#.#.#.#.#.#.#######.#.#.#.###.#.#######
#.#.#...#.......#.......#...#.#.....#...#.#...#.#.....#.#.#...#.#.....###...#.......#...###...#.#...#...#.#...#.#.......#...#.#...#...#...###
#.#.#.#.#######.#.#####.#.###.#.###.#.#.#.#####.#####.#.#.###.#.#########.###########.#######.#.###.#####.#####.#######.#####.###.#####.#.###
#.#...#.........#.#.....#.###.#.###...#.#.....#.#...#.#.#.#...#.........#.....#.....#.#.......#.....#...#...###...#...#.....#.....#.....#...#
#.###############.#.#####.###.#.#######.#####.#.#.#.#.#.#.#.###########.#####.#.###.#.#.#############.#.###.#####.#.#.#####.#######.#######.#
#...#...#...#...#.#.#...#...#.#.#...#...#...#.#.#.#.#.#.#.#.....#.....#.#.....#.#...#.#...#...#...#...#...#.#...#.#.#.#...#.........#...#...#
###.#.#.#.#.#.#.#.#.#.#.###.#.#.#.#.#.###.#.#.#.#.#.#.#.#.#####.#.###.#.#.#####.#.###.###.#.#.#.#.#.#####.#.#.#.#.#.#.#.#.###########.#.#.###
#...#.#...#...#...#.#.#.#...#.#.#.#...#...#.#.#.#.#.#.#.#.#.....#.###...#...#...#...#.#...#.#.#.#.#.....#.#.#.#...#.#.#.#...#...#...#.#.#...#
#.###.#############.#.#.#.###.#.#.#####.###.#.#.#.#.#.#.#.#.#####.#########.#.#####.#.#.###.#.#.#.#####.#.#.#.#####.#.#.###.#.#.#.#.#.#.###.#
#.....###...........#.#.#.###...#.#...#...#.#.#...#...#.#.#.#...#.........#.#.#.....#.#...#.#...#.#...#.#...#...#...#.#...#...#...#.#.#.#...#
#########.###########.#.#.#######.#.#.###.#.#.#########.#.#.#.#.#########.#.#.#.#####.###.#.#####.#.#.#.#######.#.###.###.#########.#.#.#.###
#...#...#.....#.....#.#...#.......#.#.#...#.#.........#.#.#.#.#...#.......#.#.#.....#...#.#...#...#.#.#.###...#.#...#.#...#.......#.#.#.#...#
#.#.#.#.#####.#.###.#.#####.#######.#.#.###.#########.#.#.#.#.###.#.#######.#.#####.###.#.###.#.###.#.#.###.#.#.###.#.#.###.#####.#.#.#.###.#
#.#.#.#.#...#.#.#...#...#...#...#...#.#...#.#...#.....#.#.#.#.#...#.#.......#.###...#...#.#...#...#.#.#...#.#.#.#...#.#.....#...#.#...#.....#
#.#.#.#.#.#.#.#.#.#####.#.###.#.#.###.###.#.#.#.#.#####.#.#.#.#.###.#.#######.###.###.###.#.#####.#.#.###.#.#.#.#.###.#######.#.#.###########
#.#...#...#...#.#...#...#...#.#.#.###...#.#.#.#...#...#...#.#.#...#.#.#.....#...#.#...#...#.#.....#.#.....#.#...#...#.......#.#...#.........#
#.#############.###.#.#####.#.#.#.#####.#.#.#.#####.#.#####.#.###.#.#.#.###.###.#.#.###.###.#.#####.#######.#######.#######.#.#####.#######.#
#...#.......#...#...#.....#.#.#.#.....#.#.#.#.......#...###...###...#.#.#...#...#.#.#...#...#.#...#.#.......#.....#.......#.#.......#.......#
###.#.#####.#.###.#######.#.#.#.#####.#.#.#.###########.#############.#.#.###.###.#.#.###.###.#.#.#.#.#######.###.#######.#.#########.#######
#...#...#...#.#...#.....#.#.#.#.#...#.#.#.#...#.....#...#...#####...#.#.#...#...#...#...#...#.#.#.#.#...#...#...#...#...#.#.#...#...#.......#
#.#####.#.###.#.###.###.#.#.#.#.#.#.#.#.#.###.#.###.#.###.#.#####.#.#.#.###.###.#######.###.#.#.#.#.###.#.#.###.###.#.#.#.#.#.#.#.#.#######.#
#.....#.#...#.#...#.#...#.#.#.#...#.#.#.#...#.#.###.#.....#...#...#...#.###...#...#.....#...#...#.#...#...#.#...###.#.#.#.#.#.#.#.#...#.....#
#####.#.###.#.###.#.#.###.#.#.#####.#.#.###.#.#.###.#########.#.#######.#####.###.#.#####.#######.###.#####.#.#####.#.#.#.#.#.#.#.###.#.#####
#.....#.###...###...#.#...#...#.....#.#...#.#.#.#...#.......#.#.#.....#.#...#.#...#.#...#.....#...#...#.....#.....#.#.#.#.#.#.#.#...#.#.....#
#.#####.#############.#.#######.#####.###.#.#.#.#.###.#####.#.#.#.###.#.#.#.#.#.###.#.#.#####.#.###.###.#########.#.#.#.#.#.#.#.###.#.#####.#
#.#...#.....#.........#.......#.#...#...#.#.#.#.#...#.....#.#.#.#.#...#.#.#...#...#.#.#...#...#...#...#.#...#...#.#.#.#.#.#.#.#.#...#...#...#
#.#.#.#####.#.###############.#.#.#.###.#.#.#.#.###.#####.#.#.#.#.#.###.#.#######.#.#.###.#.#####.###.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#####.#.###
#...#.......#.................#...#.....#...#...###.......#...#...#.....#.........#...###...#####.....#...#...#...#...#...#...#...#####...###
#############################################################################################################################################";
const string inputTest = @"###############
#...#...#.....#
#.#.#.#.#.###.#
#S#...#.#.#...#
#######.#.#.###
#######.#.#...#
#######.#.###.#
###..E#...#...#
###.#######.###
#...###...#...#
#.#####.#.###.#
#.#...#.#.#...#
#.#.#.#.#.#.###
#...#...#...###
###############";

void Part1(string input) {
    var grid = input.Split(Environment.NewLine).Select(x => x.ToCharArray()).ToArray();
    grid.TryFindCell( 'S', out var start);
    grid.TryFindCell('E', out var end);
    var current = start;
    var path = new Dictionary<Grid.Position, int>();
    path[current] = 0;
    while( current != end) {
        foreach (var next in grid.Neighbors(current).Where( n=> grid.GetCell(n) != '#' && !path.ContainsKey(n)))
        {
            current = next;
            path[next] = path.Count;
        }
    }
    
    var counts = new int[grid.Length * grid[0].Length];
    foreach (var kv in path)
    {
        foreach (var cheat1 in grid.Neighbors(kv.Key).Where(n=>!path.ContainsKey(n))) {
            foreach (var cheat2 in grid.Neighbors(cheat1).Where( n=> path.ContainsKey(n))) {
                int savings = path[cheat2] - kv.Value -2;
                if( savings > 0) {
                    counts[savings]++;
                }
                
            }
        }
    }
    
    Console.WriteLine(path.Count - 1);
    Console.WriteLine(string.Join("\n",
        counts.Select(((v, index) => (v, index))).Where(kv => kv.v > 0)
            .Select(kv => $"{kv.v} cheats save {kv.index} steps")));
    
    Console.WriteLine(counts.Skip(100).Sum());
}


void Part2(string input) {
    var grid = input.Split(Environment.NewLine).Select(x => x.ToCharArray()).ToArray();
    grid.TryFindCell( 'S', out var start);
    grid.TryFindCell('E', out var end);
    var current = start;
    var path = new Dictionary<Grid.Position, int>();
    path[current] = 0;
    while( current != end) {
        foreach (var next in grid.Neighbors(current).Where( n=> grid.GetCell(n) != '#' && !path.ContainsKey(n)))
        {
            current = next;
            path[next] = path.Count;
        }
    }
    
    var counts = new int[grid.Length * grid[0].Length];
    foreach (var kv in path)
    {
        for (int i = kv.Key.I - 20; i <= kv.Key.I + 20; i++) {
            for (int j = kv.Key.J - 20; j <= kv.Key.J + 20; j++) {
                int delta = Math.Abs(i - kv.Key.I) + Math.Abs(j - kv.Key.J);
                if( delta is < 2 or > 20) continue;
                if( !grid.HasCell( i,j) || grid[i][j] == '#') continue;
                
                var n = new Grid.Position(i, j);
                int savings = path[n] - kv.Value - delta;
                if( savings > 0) {
                    counts[savings]++;
                }
            }
        }
    }
    
    Console.WriteLine(path.Count - 1);
    int minSaving = 100;
    int sum = 0;
    for( int i = minSaving; i < counts.Length; i++) {
        if( counts[i] == 0) continue;
        Console.WriteLine($"{counts[i]} save {i} picoseconds");
        sum += counts[i];
    }
    Console.WriteLine(sum);
}


Part2(inputReal); 